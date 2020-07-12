namespace Avaliacao2POO {
	partial class frmAdicionarFATD {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarFATD));
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.cmbGravidade = new System.Windows.Forms.ComboBox();
			this.cmbPontos = new System.Windows.Forms.ComboBox();
			this.txtJustificativa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Location = new System.Drawing.Point(408, 339);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
			this.btnAdicionar.TabIndex = 3;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(189, 339);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(75, 23);
			this.btnVoltar.TabIndex = 2;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// txtDescricao
			// 
			this.txtDescricao.Location = new System.Drawing.Point(167, 200);
			this.txtDescricao.Multiline = true;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(167, 74);
			this.txtDescricao.TabIndex = 4;
			// 
			// cmbGravidade
			// 
			this.cmbGravidade.FormattingEnabled = true;
			this.cmbGravidade.Location = new System.Drawing.Point(167, 97);
			this.cmbGravidade.Name = "cmbGravidade";
			this.cmbGravidade.Size = new System.Drawing.Size(121, 21);
			this.cmbGravidade.TabIndex = 5;
			// 
			// cmbPontos
			// 
			this.cmbPontos.FormattingEnabled = true;
			this.cmbPontos.Location = new System.Drawing.Point(359, 97);
			this.cmbPontos.Name = "cmbPontos";
			this.cmbPontos.Size = new System.Drawing.Size(121, 21);
			this.cmbPontos.TabIndex = 6;
			// 
			// txtJustificativa
			// 
			this.txtJustificativa.Location = new System.Drawing.Point(359, 200);
			this.txtJustificativa.Multiline = true;
			this.txtJustificativa.Name = "txtJustificativa";
			this.txtJustificativa.Size = new System.Drawing.Size(167, 74);
			this.txtJustificativa.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(164, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Gravidade";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(356, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Pontos";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(164, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Descrição";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(356, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Justificativa";
			// 
			// frmAdicionarFATD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtJustificativa);
			this.Controls.Add(this.cmbPontos);
			this.Controls.Add(this.cmbGravidade);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.btnVoltar);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 500);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "frmAdicionarFATD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adicionar FATD";
			this.Load += new System.EventHandler(this.frmAdicionarFATD_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.ComboBox cmbGravidade;
		private System.Windows.Forms.ComboBox cmbPontos;
		private System.Windows.Forms.TextBox txtJustificativa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}