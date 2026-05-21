namespace CardVault
{
    partial class FrmTroca
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
            this.lblColecionador1 = new System.Windows.Forms.Label();
            this.lblColecionador2 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cboColecionador1 = new System.Windows.Forms.ComboBox();
            this.cboColecionador2 = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lstTrocas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblColecionador1
            // 
            this.lblColecionador1.AutoSize = true;
            this.lblColecionador1.Location = new System.Drawing.Point(53, 42);
            this.lblColecionador1.Name = "lblColecionador1";
            this.lblColecionador1.Size = new System.Drawing.Size(101, 16);
            this.lblColecionador1.TabIndex = 0;
            this.lblColecionador1.Text = "Colecionador 1:";
            // 
            // lblColecionador2
            // 
            this.lblColecionador2.AutoSize = true;
            this.lblColecionador2.Location = new System.Drawing.Point(53, 68);
            this.lblColecionador2.Name = "lblColecionador2";
            this.lblColecionador2.Size = new System.Drawing.Size(101, 16);
            this.lblColecionador2.TabIndex = 1;
            this.lblColecionador2.Text = "Colecionador 2:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(53, 100);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 16);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(53, 130);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(563, 22);
            this.txtObservacao.TabIndex = 3;
            this.txtObservacao.Text = "Observação:";
            // 
            // cboColecionador1
            // 
            this.cboColecionador1.FormattingEnabled = true;
            this.cboColecionador1.Location = new System.Drawing.Point(169, 34);
            this.cboColecionador1.Name = "cboColecionador1";
            this.cboColecionador1.Size = new System.Drawing.Size(436, 24);
            this.cboColecionador1.TabIndex = 4;
            // 
            // cboColecionador2
            // 
            this.cboColecionador2.FormattingEnabled = true;
            this.cboColecionador2.Location = new System.Drawing.Point(169, 64);
            this.cboColecionador2.Name = "cboColecionador2";
            this.cboColecionador2.Size = new System.Drawing.Size(436, 24);
            this.cboColecionador2.TabIndex = 5;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(98, 96);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1108, 459);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 22);
            this.textBox1.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(56, 180);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(194, 180);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(132, 23);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(332, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(132, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // lstTrocas
            // 
            this.lstTrocas.FormattingEnabled = true;
            this.lstTrocas.ItemHeight = 16;
            this.lstTrocas.Location = new System.Drawing.Point(56, 231);
            this.lstTrocas.Name = "lstTrocas";
            this.lstTrocas.Size = new System.Drawing.Size(998, 228);
            this.lstTrocas.TabIndex = 11;
            this.lstTrocas.SelectedIndexChanged += new System.EventHandler(this.lstTrocas_SelectedIndexChanged);
            // 
            // FrmTroca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 475);
            this.Controls.Add(this.lstTrocas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cboColecionador2);
            this.Controls.Add(this.cboColecionador1);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblColecionador2);
            this.Controls.Add(this.lblColecionador1);
            this.Name = "FrmTroca";
            this.Text = "FrmTroca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColecionador1;
        private System.Windows.Forms.Label lblColecionador2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cboColecionador1;
        private System.Windows.Forms.ComboBox cboColecionador2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox lstTrocas;
    }
}