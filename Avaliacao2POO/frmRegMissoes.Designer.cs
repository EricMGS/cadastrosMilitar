namespace Avaliacao2POO {
	partial class frmRegMissoes {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegMissoes));
			this.btnParticipar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnAlterarFunção = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.lstbxMissoes = new System.Windows.Forms.ListBox();
			this.cmbFuncao = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnParticipar
			// 
			this.btnParticipar.Location = new System.Drawing.Point(445, 325);
			this.btnParticipar.Name = "btnParticipar";
			this.btnParticipar.Size = new System.Drawing.Size(101, 46);
			this.btnParticipar.TabIndex = 3;
			this.btnParticipar.Text = "Participar de Missão";
			this.btnParticipar.UseVisualStyleBackColor = true;
			this.btnParticipar.Click += new System.EventHandler(this.btnParticipar_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(299, 325);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(73, 46);
			this.btnVoltar.TabIndex = 2;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// btnAlterarFunção
			// 
			this.btnAlterarFunção.Location = new System.Drawing.Point(485, 84);
			this.btnAlterarFunção.Name = "btnAlterarFunção";
			this.btnAlterarFunção.Size = new System.Drawing.Size(101, 24);
			this.btnAlterarFunção.TabIndex = 4;
			this.btnAlterarFunção.Text = "Alterar Função";
			this.btnAlterarFunção.UseVisualStyleBackColor = true;
			this.btnAlterarFunção.Click += new System.EventHandler(this.btnAlterarFunção_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(485, 196);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(61, 28);
			this.btnImprimir.TabIndex = 5;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// lstbxMissoes
			// 
			this.lstbxMissoes.FormattingEnabled = true;
			this.lstbxMissoes.Location = new System.Drawing.Point(208, 38);
			this.lstbxMissoes.Name = "lstbxMissoes";
			this.lstbxMissoes.Size = new System.Drawing.Size(203, 186);
			this.lstbxMissoes.TabIndex = 6;
			// 
			// cmbFuncao
			// 
			this.cmbFuncao.FormattingEnabled = true;
			this.cmbFuncao.Location = new System.Drawing.Point(485, 54);
			this.cmbFuncao.Name = "cmbFuncao";
			this.cmbFuncao.Size = new System.Drawing.Size(121, 21);
			this.cmbFuncao.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(482, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Função";
			// 
			// frmRegMissoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbFuncao);
			this.Controls.Add(this.lstbxMissoes);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnAlterarFunção);
			this.Controls.Add(this.btnParticipar);
			this.Controls.Add(this.btnVoltar);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 500);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "frmRegMissoes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registros de Missões";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnParticipar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnAlterarFunção;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.ListBox lstbxMissoes;
		private System.Windows.Forms.ComboBox cmbFuncao;
		private System.Windows.Forms.Label label1;
	}
}