using CardVault.DAO;
using CardVault.Model;
using System;
using System.Windows.Forms;

namespace CardVault
{
    public partial class FrmColecionador : Form
    {
        private ColecionadorDAO dao = new ColecionadorDAO();
        private int idSelecionado = 0;

        public FrmColecionador()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void CarregarLista()
        {
            lstColecionadores.DataSource = null;
            lstColecionadores.DataSource = dao.Listar();
            lstColecionadores.DisplayMember = "Nome";
            lstColecionadores.ValueMember = "Id";
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Nome é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var c = new Colecionador
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Telefone = txtTelefone.Text,
                    DataCadastro = DateTime.Now
                };

                dao.Inserir(c);
                MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (idSelecionado == 0)
                {
                    MessageBox.Show("Selecione um colecionador!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Nome é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var c = new Colecionador
                {
                    Id = idSelecionado,
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Telefone = txtTelefone.Text
                };

                dao.Editar(c);
                MessageBox.Show("Editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (idSelecionado == 0)
                {
                    MessageBox.Show("Selecione um colecionador!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void lstColecionadores_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstColecionadores.SelectedItem is Colecionador c)
            {
                idSelecionado = c.Id;
                txtNome.Text = c.Nome;
                txtEmail.Text = c.Email;
                txtTelefone.Text = c.Telefone;
            }
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            idSelecionado = 0;
            lstColecionadores.SelectedIndex = -1;
        }
    }
}