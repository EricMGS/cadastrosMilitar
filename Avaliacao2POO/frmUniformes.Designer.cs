namespace Avaliacao2POO {
	partial class frmUniformes {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUniformes));
			this.lstbxUniformes = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.btnMudarParaRala = new System.Windows.Forms.Button();
			this.btnMudarParaUso = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstbxUniformes
			// 
			this.lstbxUniformes.FormattingEnabled = true;
			this.lstbxUniformes.Location = new System.Drawing.Point(132, 70);
			this.lstbxUniformes.Name = "lstbxUniformes";
			this.lstbxUniformes.Size = new System.Drawing.Size(252, 225);
			this.lstbxUniformes.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(133, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Uniformes";
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Location = new System.Drawing.Point(372, 354);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(121, 23);
			this.btnAdicionar.TabIndex = 5;
			this.btnAdicionar.Text = "Adicionar uniforme";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(199, 354);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(121, 23);
			this.btnVoltar.TabIndex = 11;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(436, 70);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir.TabIndex = 12;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// btnMudarParaRala
			// 
			this.btnMudarParaRala.Location = new System.Drawing.Point(436, 164);
			this.btnMudarParaRala.Name = "btnMudarParaRala";
			this.btnMudarParaRala.Size = new System.Drawing.Size(118, 23);
			this.btnMudarParaRala.TabIndex = 13;
			this.btnMudarParaRala.Text = "Mudar para Rala";
			this.btnMudarParaRala.UseVisualStyleBackColor = true;
			this.btnMudarParaRala.Click += new System.EventHandler(this.btnMudarParaRala_Click);
			// 
			// btnMudarParaUso
			// 
			this.btnMudarParaUso.Location = new System.Drawing.Point(436, 193);
			this.btnMudarParaUso.Name = "btnMudarParaUso";
			this.btnMudarParaUso.Size = new System.Drawing.Size(118, 23);
			this.btnMudarParaUso.TabIndex = 14;
			this.btnMudarParaUso.Text = "Mudar para Uso";
			this.btnMudarParaUso.UseVisualStyleBackColor = true;
			this.btnMudarParaUso.Click += new System.EventHandler(this.btnMudarParaUso_Click);
			// 
			// frmUniformes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.btnMudarParaUso);
			this.Controls.Add(this.btnMudarParaRala);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstbxUniformes);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 500);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "frmUniformes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Uniformes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstbxUniformes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnMudarParaRala;
		private System.Windows.Forms.Button btnMudarParaUso;
	}
}