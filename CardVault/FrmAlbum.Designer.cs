namespace CardVault
{
    partial class FrmAlbum
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblColecionador = new System.Windows.Forms.Label();
            this.cboColecionador = new System.Windows.Forms.ComboBox();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(53, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(53, 110);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(46, 16);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Tema:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(53, 145);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(34, 16);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(153, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(546, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(153, 107);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(546, 22);
            this.txtTema.TabIndex = 5;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(153, 139);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(546, 22);
            this.txtAno.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(153, 216);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(254, 216);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(355, 216);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(95, 23);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(456, 216);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // lblColecionador
            // 
            this.lblColecionador.AutoSize = true;
            this.lblColecionador.Location = new System.Drawing.Point(53, 175);
            this.lblColecionador.Name = "lblColecionador";
            this.lblColecionador.Size = new System.Drawing.Size(94, 16);
            this.lblColecionador.TabIndex = 3;
            this.lblColecionador.Text = "Colecionador: ";
            // 
            // cboColecionador
            // 
            this.cboColecionador.FormattingEnabled = true;
            this.cboColecionador.Location = new System.Drawing.Point(153, 167);
            this.cboColecionador.Name = "cboColecionador";
            this.cboColecionador.Size = new System.Drawing.Size(546, 24);
            this.cboColecionador.TabIndex = 13;
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.ItemHeight = 16;
            this.lstAlbums.Location = new System.Drawing.Point(56, 250);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(643, 164);
            this.lstAlbums.TabIndex = 14;
            this.lstAlbums.SelectedIndexChanged += new System.EventHandler(this.lstAlbums_SelectedIndexChanged_1);
            // 
            // FrmAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 519);
            this.Controls.Add(this.lstAlbums);
            this.Controls.Add(this.cboColecionador);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblColecionador);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmAlbum";
            this.Text = "FrmAlbum";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblColecionador;
        private System.Windows.Forms.ComboBox cboColecionador;
        private System.Windows.Forms.ListBox lstAlbums;
    }
}