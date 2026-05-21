using CardVault.DAO;
using CardVault.Model;
using System;
using System.Windows.Forms;

namespace CardVault
{
    public partial class FrmAlbum : Form
    {
        private AlbumDAO dao = new AlbumDAO();
        private ColecionadorDAO colecionadorDAO = new ColecionadorDAO();
        private int idSelecionado = 0;

        public FrmAlbum()
        {
            InitializeComponent();
            CarregarColecionadores();
            CarregarLista();
        }

        private void CarregarColecionadores()
        {
            cboColecionador.DataSource = colecionadorDAO.Listar();
            cboColecionador.DisplayMember = "Nome";
            cboColecionador.ValueMember = "Id";
        }

        private void CarregarLista()
        {
            lstAlbums.DataSource = null;
            lstAlbums.DataSource = dao.Listar();
            lstAlbums.DisplayMember = "Nome";
            lstAlbums.ValueMember = "Id";
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

                if (string.IsNullOrEmpty(txtAno.Text))
                {
                    MessageBox.Show("Ano é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var a = new Album
                {
                    Nome = txtNome.Text,
                    Tema = txtTema.Text,
                    AnoLancamento = int.Parse(txtAno.Text),
                    IdColecionador = (int)cboColecionador.SelectedValue
                };

                dao.Inserir(a);
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
                    MessageBox.Show("Selecione um álbum!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Nome é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var a = new Album
                {
                    Id = idSelecionado,
                    Nome = txtNome.Text,
                    Tema = txtTema.Text,
                    AnoLancamento = int.Parse(txtAno.Text),
                    IdColecionador = (int)cboColecionador.SelectedValue
                };

                dao.Editar(a);
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
                    MessageBox.Show("Selecione um álbum!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void lstAlbums_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstAlbums.SelectedItem is Album a)
            {
                idSelecionado = a.Id;
                txtNome.Text = a.Nome;
                txtTema.Text = a.Tema;
                txtAno.Text = a.AnoLancamento.ToString();
                cboColecionador.SelectedValue = a.IdColecionador;
            }
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtTema.Text = "";
            txtAno.Text = "";
            idSelecionado = 0;
            lstAlbums.SelectedIndex = -1;
            cboColecionador.SelectedIndex = 0;
        }
    }
}