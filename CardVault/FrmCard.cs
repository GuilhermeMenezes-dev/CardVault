using CardVault.DAO;
using CardVault.Model;
using System;
using System.Windows.Forms;

namespace CardVault
{
    public partial class FrmCard : Form
    {
        private CardDAO dao = new CardDAO();
        private AlbumDAO albumDAO = new AlbumDAO();
        private int idSelecionado = 0;

        public FrmCard()
        {
            InitializeComponent();
            CarregarRaridades();
            CarregarAlbums();
            CarregarLista();
        }

        private void CarregarRaridades()
        {
            cboRaridade.Items.Clear();
            cboRaridade.Items.Add("Comum");
            cboRaridade.Items.Add("Raro");
            cboRaridade.Items.Add("Lendário");
            cboRaridade.SelectedIndex = 0;
        }

        private void CarregarAlbums()
        {
            cboAlbum.DataSource = albumDAO.Listar();
            cboAlbum.DisplayMember = "Nome";
            cboAlbum.ValueMember = "Id";
        }

        private void CarregarLista()
        {
            lstCards.DataSource = null;
            lstCards.DataSource = dao.Listar();
            lstCards.DisplayMember = "Nome";
            lstCards.ValueMember = "Id";
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

                if (string.IsNullOrEmpty(txtNumero.Text))
                {
                    MessageBox.Show("Número é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var c = new Card
                {
                    Nome = txtNome.Text,
                    Numero = int.Parse(txtNumero.Text),
                    Raridade = cboRaridade.SelectedItem.ToString(),
                    Descricao = txtDescricao.Text,
                    IdAlbum = (int)cboAlbum.SelectedValue
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
                    MessageBox.Show("Selecione um card!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Nome é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var c = new Card
                {
                    Id = idSelecionado,
                    Nome = txtNome.Text,
                    Numero = int.Parse(txtNumero.Text),
                    Raridade = cboRaridade.SelectedItem.ToString(),
                    Descricao = txtDescricao.Text,
                    IdAlbum = (int)cboAlbum.SelectedValue
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
                    MessageBox.Show("Selecione um card!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void lstCards_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstCards.SelectedItem is Card c)
            {
                idSelecionado = c.Id;
                txtNome.Text = c.Nome;
                txtNumero.Text = c.Numero.ToString();
                cboRaridade.SelectedItem = c.Raridade;
                txtDescricao.Text = c.Descricao;
                cboAlbum.SelectedValue = c.IdAlbum;
            }
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtNumero.Text = "";
            txtDescricao.Text = "";
            idSelecionado = 0;
            lstCards.SelectedIndex = -1;
            cboRaridade.SelectedIndex = 0;
            cboAlbum.SelectedIndex = 0;
        }
    }
}