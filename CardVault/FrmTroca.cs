using CardVault.DAO;
using CardVault.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardVault
{
    public partial class FrmTroca : Form
    {
        private TrocaDAO dao = new TrocaDAO();
        private ColecionadorDAO colecionadorDAO = new ColecionadorDAO();
        private int idSelecionado = 0;
        public FrmTroca()
        {
            InitializeComponent();
            CarregarColecionadores();
            CarregarLista();
        }
        private void CarregarColecionadores()
        {
            var lista = colecionadorDAO.Listar();

            cboColecionador1.DataSource = lista;
            cboColecionador1.DisplayMember = "Nome";
            cboColecionador1.ValueMember = "Id";

            cboColecionador2.DataSource = lista.ToList();
            cboColecionador2.DisplayMember = "Nome";
            cboColecionador2.ValueMember = "Id";
        }

        private void CarregarLista()
        {
            lstTrocas.DataSource = null;
            var trocas = dao.Listar();
            var colecionadores = colecionadorDAO.Listar();

            lstTrocas.DataSource = trocas.Select(t => new {
                Id = t.Id,
                Display = $"Troca #{t.Id} | {colecionadores.FirstOrDefault(c => c.Id == t.IdColecionador1)?.Nome} → {colecionadores.FirstOrDefault(c => c.Id == t.IdColecionador2)?.Nome} | {t.DataTroca:dd/MM/yyyy} | {t.Observacao}"
            }).ToList();

            lstTrocas.DisplayMember = "Display";
            lstTrocas.ValueMember = "Id";
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cboColecionador1.SelectedValue == cboColecionador2.SelectedValue)
                {
                    MessageBox.Show("Os colecionadores devem ser diferentes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var t = new Troca
                {
                    IdColecionador1 = (int)cboColecionador1.SelectedValue,
                    IdColecionador2 = (int)cboColecionador2.SelectedValue,
                    DataTroca = dtpData.Value,
                    Observacao = txtObservacao.Text
                };

                dao.Inserir(t);
                MessageBox.Show("Troca registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (idSelecionado == 0)
                {
                    MessageBox.Show("Selecione uma troca!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirma = MessageBox.Show("Deseja deletar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirma == DialogResult.Yes)
                {
                    dao.Deletar(idSelecionado);
                    MessageBox.Show("Deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    CarregarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

        private void lstTrocas_SelectedIndexChanged(object sender, EventArgs e)
        {
   
                if (lstTrocas.SelectedValue != null && int.TryParse(lstTrocas.SelectedValue.ToString(), out int id))
                {
                    var trocas = dao.Listar();
                    var t = trocas.FirstOrDefault(x => x.Id == id);
                    if (t != null)
                    {
                        idSelecionado = t.Id;
                        cboColecionador1.SelectedValue = t.IdColecionador1;
                        cboColecionador2.SelectedValue = t.IdColecionador2;
                        dtpData.Value = t.DataTroca;
                        txtObservacao.Text = t.Observacao;
                    }
                }
            
        }

        private void Limpar()
        {
            txtObservacao.Text = "";
            idSelecionado = 0;
            lstTrocas.SelectedIndex = -1;
            cboColecionador1.SelectedIndex = 0;
            cboColecionador2.SelectedIndex = 0;
            dtpData.Value = DateTime.Now;
        }

        private void FrmTroca_Load(object sender, EventArgs e)
        {

        }
    }
}
