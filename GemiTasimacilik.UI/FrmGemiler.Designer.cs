namespace GemiTasimacilik.UI
{
	partial class FrmGemiler
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.tbGemiAdi = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnGec = new System.Windows.Forms.Button();
			this.lstGemiler = new System.Windows.Forms.ListBox();
			this.numKapasite = new System.Windows.Forms.NumericUpDown();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numKapasite)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(13, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gemi Adı:";
			// 
			// tbGemiAdi
			// 
			this.tbGemiAdi.Location = new System.Drawing.Point(157, 47);
			this.tbGemiAdi.Name = "tbGemiAdi";
			this.tbGemiAdi.Size = new System.Drawing.Size(121, 20);
			this.tbGemiAdi.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(13, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "Toplam Kapasite:";
			// 
			// btnEkle
			// 
			this.btnEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEkle.Location = new System.Drawing.Point(63, 146);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(75, 23);
			this.btnEkle.TabIndex = 4;
			this.btnEkle.Text = "EKLE";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnGec
			// 
			this.btnGec.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGec.Location = new System.Drawing.Point(158, 146);
			this.btnGec.Name = "btnGec";
			this.btnGec.Size = new System.Drawing.Size(75, 23);
			this.btnGec.TabIndex = 4;
			this.btnGec.Text = "GEÇ";
			this.btnGec.UseVisualStyleBackColor = true;
			this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
			// 
			// lstGemiler
			// 
			this.lstGemiler.FormattingEnabled = true;
			this.lstGemiler.Location = new System.Drawing.Point(317, 12);
			this.lstGemiler.Name = "lstGemiler";
			this.lstGemiler.Size = new System.Drawing.Size(172, 199);
			this.lstGemiler.TabIndex = 5;
			// 
			// numKapasite
			// 
			this.numKapasite.Location = new System.Drawing.Point(158, 91);
			this.numKapasite.Name = "numKapasite";
			this.numKapasite.Size = new System.Drawing.Size(120, 20);
			this.numKapasite.TabIndex = 6;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FrmGemiler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(512, 239);
			this.Controls.Add(this.numKapasite);
			this.Controls.Add(this.lstGemiler);
			this.Controls.Add(this.btnGec);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.tbGemiAdi);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "FrmGemiler";
			this.Text = "GEMİLER";
			((System.ComponentModel.ISupportInitialize)(this.numKapasite)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbGemiAdi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnGec;
		private System.Windows.Forms.ListBox lstGemiler;
		private System.Windows.Forms.NumericUpDown numKapasite;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}

