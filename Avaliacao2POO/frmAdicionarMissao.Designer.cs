namespace Avaliacao2POO {
	partial class frmAdicionarMissao {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarMissao));
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.cmbMissoes = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbFuncoes = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(237, 287);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(61, 28);
			this.btnVoltar.TabIndex = 0;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Location = new System.Drawing.Point(349, 287);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(101, 28);
			this.btnAdicionar.TabIndex = 1;
			this.btnAdicionar.Text = "Adicionar Missão";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// cmbMissoes
			// 
			this.cmbMissoes.FormattingEnabled = true;
			this.cmbMissoes.Location = new System.Drawing.Point(269, 151);
			this.cmbMissoes.Name = "cmbMissoes";
			this.cmbMissoes.Size = new System.Drawing.Size(121, 21);
			this.cmbMissoes.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(266, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Missão";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(266, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Função";
			// 
			// cmbFuncoes
			// 
			this.cmbFuncoes.FormattingEnabled = true;
			this.cmbFuncoes.Location = new System.Drawing.Point(269, 205);
			this.cmbFuncoes.Name = "cmbFuncoes";
			this.cmbFuncoes.Size = new System.Drawing.Size(121, 21);
			this.cmbFuncoes.TabIndex = 4;
			// 
			// frmAdicionarMissao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbFuncoes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbMissoes);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.btnVoltar);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 500);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "frmAdicionarMissao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adicionar Missão";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.ComboBox cmbMissoes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbFuncoes;
	}
}