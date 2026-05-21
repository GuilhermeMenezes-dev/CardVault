using System;
using System.Windows.Forms;

namespace CardVault
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnColecionadores_Click_1(object sender, EventArgs e)
        {
            FrmColecionador frm = new FrmColecionador();
            frm.ShowDialog();
        }

        private void btnAlbums_Click_1(object sender, EventArgs e)
        {
            FrmAlbum frm = new FrmAlbum();
            frm.ShowDialog();
        }

        private void btnCards_Click_1(object sender, EventArgs e)
        {
            FrmCard frm = new FrmCard();
            frm.ShowDialog();
        }

        private void btnTrocas_Click_1(object sender, EventArgs e)
        {
            FrmTroca frm = new FrmTroca();
            frm.ShowDialog();
        }
    }
}