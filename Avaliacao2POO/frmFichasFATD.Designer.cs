namespace Avaliacao2POO {
	partial class frmFichasFATD {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFichasFATD));
			this.btnGerarPunicao = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbFicha = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lstbxFATDs = new System.Windows.Forms.ListBox();
			this.txtPontuacao = new System.Windows.Forms.TextBox();
			this.Pontuação = new System.Windows.Forms.Label();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnImprimirFicha = new System.Windows.Forms.Button();
			this.btnCalcPontuacao = new System.Windows.Forms.Button();
			this.btnImprimirFATD = new System.Windows.Forms.Button();
			this.btnApurar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGerarPunicao
			// 
			this.btnGerarPunicao.Location = new System.Drawing.Point(486, 229);
			this.btnGerarPunicao.Name = "btnGerarPunicao";
			this.btnGerarPunicao.Size = new System.Drawing.Size(111, 23);
			this.btnGerarPunicao.TabIndex = 15;
			this.btnGerarPunicao.Text = "Gerar punição";
			this.btnGerarPunicao.UseVisualStyleBackColor = true;
			this.btnGerarPunicao.Click += new System.EventHandler(this.btnGerarPunicao_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(105, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "FATDs";
			// 
			// cmbFicha
			// 
			this.cmbFicha.FormattingEnabled = true;
			this.cmbFicha.Location = new System.Drawing.Point(108, 58);
			this.cmbFicha.Name = "cmbFicha";
			this.cmbFicha.Size = new System.Drawing.Size(121, 21);
			this.cmbFicha.TabIndex = 13;
			this.cmbFicha.SelectedIndexChanged += new System.EventHandler(this.cmbFicha_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(105, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Ficha / Organização";
			// 
			// lstbxFATDs
			// 
			this.lstbxFATDs.FormattingEnabled = true;
			this.lstbxFATDs.Location = new System.Drawing.Point(108, 119);
			this.lstbxFATDs.Name = "lstbxFATDs";
			this.lstbxFATDs.Size = new System.Drawing.Size(177, 173);
			this.lstbxFATDs.TabIndex = 11;
			// 
			// txtPontuacao
			// 
			this.txtPontuacao.Location = new System.Drawing.Point(348, 119);
			this.txtPontuacao.Name = "txtPontuacao";
			this.txtPontuacao.ReadOnly = true;
			this.txtPontuacao.Size = new System.Drawing.Size(100, 20);
			this.txtPontuacao.TabIndex = 18;
			// 
			// Pontuação
			// 
			this.Pontuação.AutoSize = true;
			this.Pontuação.Location = new System.Drawing.Point(345, 103);
			this.Pontuação.Name = "Pontuação";
			this.Pontuação.Size = new System.Drawing.Size(59, 13);
			this.Pontuação.TabIndex = 19;
			this.Pontuação.Text = "Pontuação";
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Location = new System.Drawing.Point(368, 342);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(121, 23);
			this.btnAdicionar.TabIndex = 20;
			this.btnAdicionar.Text = "Adicionar FATD";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(207, 342);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(121, 23);
			this.btnVoltar.TabIndex = 21;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// btnImprimirFicha
			// 
			this.btnImprimirFicha.Location = new System.Drawing.Point(485, 116);
			this.btnImprimirFicha.Name = "btnImprimirFicha";
			this.btnImprimirFicha.Size = new System.Drawing.Size(112, 23);
			this.btnImprimirFicha.TabIndex = 22;
			this.btnImprimirFicha.Text = "Imprimir Ficha";
			this.btnImprimirFicha.UseVisualStyleBackColor = true;
			this.btnImprimirFicha.Click += new System.EventHandler(this.btnImprimirFicha_Click);
			// 
			// btnCalcPontuacao
			// 
			this.btnCalcPontuacao.Location = new System.Drawing.Point(487, 200);
			this.btnCalcPontuacao.Name = "btnCalcPontuacao";
			this.btnCalcPontuacao.Size = new System.Drawing.Size(110, 23);
			this.btnCalcPontuacao.TabIndex = 23;
			this.btnCalcPontuacao.Text = "Calcular Pontuação";
			this.btnCalcPontuacao.UseVisualStyleBackColor = true;
			this.btnCalcPontuacao.Click += new System.EventHandler(this.btnCalcPontuacao_Click);
			// 
			// btnImprimirFATD
			// 
			this.btnImprimirFATD.Location = new System.Drawing.Point(485, 145);
			this.btnImprimirFATD.Name = "btnImprimirFATD";
			this.btnImprimirFATD.Size = new System.Drawing.Size(112, 23);
			this.btnImprimirFATD.TabIndex = 24;
			this.btnImprimirFATD.Text = "Imprimir FATD";
			this.btnImprimirFATD.UseVisualStyleBackColor = true;
			this.btnImprimirFATD.Click += new System.EventHandler(this.btnImprimirFATD_Click);
			// 
			// btnApurar
			// 
			this.btnApurar.Location = new System.Drawing.Point(486, 174);
			this.btnApurar.Name = "btnApurar";
			this.btnApurar.Size = new System.Drawing.Size(111, 23);
			this.btnApurar.TabIndex = 25;
			this.btnApurar.Text = "Apurar Justificativa";
			this.btnApurar.UseVisualStyleBackColor = true;
			this.btnApurar.Click += new System.EventHandler(this.btnApurar_Click);
			// 
			// frmFichasFATD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.btnApurar);
			this.Controls.Add(this.btnImprimirFATD);
			this.Controls.Add(this.btnCalcPontuacao);
			this.Controls.Add(this.btnImprimirFicha);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.Pontuação);
			this.Controls.Add(this.txtPontuacao);
			this.Controls.Add(this.btnGerarPunicao);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbFicha);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstbxFATDs);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 500);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "frmFichasFATD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fichas FATD";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnGerarPunicao;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbFicha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstbxFATDs;
		private System.Windows.Forms.TextBox txtPontuacao;
		private System.Windows.Forms.Label Pontuação;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnImprimirFicha;
		private System.Windows.Forms.Button btnCalcPontuacao;
		private System.Windows.Forms.Button btnImprimirFATD;
		private System.Windows.Forms.Button btnApurar;
	}
}