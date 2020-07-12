namespace Avaliacao2POO {
	partial class frmCadastrarMilitar {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarMilitar));
			this.cmbOM = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbPatente = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtRegistro = new System.Windows.Forms.TextBox();
			this.txtNomeGuerra = new System.Windows.Forms.TextBox();
			this.txtNomeCompleto = new System.Windows.Forms.TextBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbOM
			// 
			this.cmbOM.FormattingEnabled = true;
			this.cmbOM.Location = new System.Drawing.Point(224, 91);
			this.cmbOM.Name = "cmbOM";
			this.cmbOM.Size = new System.Drawing.Size(121, 21);
			this.cmbOM.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(221, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Organização Militar";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(387, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nome Completo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(221, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nome de Guerra";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(221, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Patente";
			// 
			// cmbPatente
			// 
			this.cmbPatente.FormattingEnabled = true;
			this.cmbPatente.Location = new System.Drawing.Point(224, 240);
			this.cmbPatente.Name = "cmbPatente";
			this.cmbPatente.Size = new System.Drawing.Size(121, 21);
			this.cmbPatente.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(387, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Registro Militar";
			// 
			// txtRegistro
			// 
			this.txtRegistro.Location = new System.Drawing.Point(390, 241);
			this.txtRegistro.Name = "txtRegistro";
			this.txtRegistro.Size = new System.Drawing.Size(100, 20);
			this.txtRegistro.TabIndex = 13;
			// 
			// txtNomeGuerra
			// 
			this.txtNomeGuerra.Location = new System.Drawing.Point(224, 182);
			this.txtNomeGuerra.Name = "txtNomeGuerra";
			this.txtNomeGuerra.Size = new System.Drawing.Size(100, 20);
			this.txtNomeGuerra.TabIndex = 14;
			// 
			// txtNomeCompleto
			// 
			this.txtNomeCompleto.Location = new System.Drawing.Point(391, 92);
			this.txtNomeCompleto.Name = "txtNomeCompleto";
			this.txtNomeCompleto.Size = new System.Drawing.Size(182, 20);
			this.txtNomeCompleto.TabIndex = 15;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(352, 324);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(126, 23);
			this.btnCadastrar.TabIndex = 16;
			this.btnCadastrar.Text = "Cadastrar Militar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(224, 324);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(126, 23);
			this.btnVoltar.TabIndex = 17;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// frmCadastrarMilitar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtNomeCompleto);
			this.Controls.Add(this.txtNomeGuerra);
			this.Controls.Add(this.txtRegistro);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbPatente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbOM);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 500);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "frmCadastrarMilitar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar Militar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbOM;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbPatente;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtRegistro;
		private System.Windows.Forms.TextBox txtNomeGuerra;
		private System.Windows.Forms.TextBox txtNomeCompleto;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Button btnVoltar;
	}
}