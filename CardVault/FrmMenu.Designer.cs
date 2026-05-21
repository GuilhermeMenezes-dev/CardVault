namespace CardVault
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnColecionadores = new System.Windows.Forms.Button();
            this.btnCards = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            this.btnTrocas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(347, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(66, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CardVault";
            // 
            // btnColecionadores
            // 
            this.btnColecionadores.Location = new System.Drawing.Point(138, 125);
            this.btnColecionadores.Name = "btnColecionadores";
            this.btnColecionadores.Size = new System.Drawing.Size(195, 23);
            this.btnColecionadores.TabIndex = 1;
            this.btnColecionadores.Text = "Colecionadores";
            this.btnColecionadores.UseVisualStyleBackColor = true;
            this.btnColecionadores.Click += new System.EventHandler(this.btnColecionadores_Click_1);
            // 
            // btnCards
            // 
            this.btnCards.Location = new System.Drawing.Point(138, 174);
            this.btnCards.Name = "btnCards";
            this.btnCards.Size = new System.Drawing.Size(195, 23);
            this.btnCards.TabIndex = 2;
            this.btnCards.Text = "Cards";
            this.btnCards.UseVisualStyleBackColor = true;
            this.btnCards.Click += new System.EventHandler(this.btnCards_Click_1);
            // 
            // btnAlbums
            // 
            this.btnAlbums.Location = new System.Drawing.Point(430, 125);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(195, 23);
            this.btnAlbums.TabIndex = 3;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.UseVisualStyleBackColor = true;
            this.btnAlbums.Click += new System.EventHandler(this.btnAlbums_Click_1);
            // 
            // btnTrocas
            // 
            this.btnTrocas.Location = new System.Drawing.Point(430, 174);
            this.btnTrocas.Name = "btnTrocas";
            this.btnTrocas.Size = new System.Drawing.Size(195, 23);
            this.btnTrocas.TabIndex = 4;
            this.btnTrocas.Text = "Trocas";
            this.btnTrocas.UseVisualStyleBackColor = true;
            this.btnTrocas.Click += new System.EventHandler(this.btnTrocas_Click_1);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrocas);
            this.Controls.Add(this.btnAlbums);
            this.Controls.Add(this.btnCards);
            this.Controls.Add(this.btnColecionadores);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnColecionadores;
        private System.Windows.Forms.Button btnCards;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnTrocas;
    }
}