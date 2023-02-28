namespace GemiTasimacilik.UI
{
	partial class FrmRotalar
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
			this.cmbVaris = new System.Windows.Forms.ComboBox();
			this.cmbAraLiman = new System.Windows.Forms.ComboBox();
			this.cmbKalkis = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbGemiler = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnGec = new System.Windows.Forms.Button();
			this.lstRotalar = new System.Windows.Forms.ListBox();
			this.dtpKalkis = new System.Windows.Forms.DateTimePicker();
			this.dtpAraTarih = new System.Windows.Forms.DateTimePicker();
			this.dtpVarisTarih = new System.Windows.Forms.DateTimePicker();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbVaris
			// 
			this.cmbVaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVaris.FormattingEnabled = true;
			this.cmbVaris.Items.AddRange(new object[] {
            "İZMİR",
            "İSTANBUL",
            "ADANA",
            "İSKENDERUN",
            "TRABZON",
            "MERSİN"});
			this.cmbVaris.Location = new System.Drawing.Point(111, 188);
			this.cmbVaris.Name = "cmbVaris";
			this.cmbVaris.Size = new System.Drawing.Size(121, 21);
			this.cmbVaris.TabIndex = 6;
			// 
			// cmbAraLiman
			// 
			this.cmbAraLiman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAraLiman.FormattingEnabled = true;
			this.cmbAraLiman.Items.AddRange(new object[] {
            "İZMİR",
            "İSTANBUL",
            "ADANA",
            "İSKENDERUN",
            "TRABZON",
            "MERSİN"});
			this.cmbAraLiman.Location = new System.Drawing.Point(111, 137);
			this.cmbAraLiman.Name = "cmbAraLiman";
			this.cmbAraLiman.Size = new System.Drawing.Size(121, 21);
			this.cmbAraLiman.TabIndex = 7;
			// 
			// cmbKalkis
			// 
			this.cmbKalkis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKalkis.FormattingEnabled = true;
			this.cmbKalkis.Items.AddRange(new object[] {
            "İZMİR",
            "İSTANBUL",
            "ADANA",
            "İSKENDERUN",
            "TRABZON",
            "MERSİN"});
			this.cmbKalkis.Location = new System.Drawing.Point(110, 94);
			this.cmbKalkis.Name = "cmbKalkis";
			this.cmbKalkis.Size = new System.Drawing.Size(121, 21);
			this.cmbKalkis.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(13, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Varış Limanı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(13, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ara Liman:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(12, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Kalkış Limanı:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(13, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "Gemiler:";
			// 
			// cmbGemiler
			// 
			this.cmbGemiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGemiler.FormattingEnabled = true;
			this.cmbGemiler.Location = new System.Drawing.Point(111, 47);
			this.cmbGemiler.Name = "cmbGemiler";
			this.cmbGemiler.Size = new System.Drawing.Size(121, 21);
			this.cmbGemiler.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(303, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 17);
			this.label6.TabIndex = 22;
			this.label6.Text = "Tarih";
			// 
			// btnEkle
			// 
			this.btnEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEkle.Location = new System.Drawing.Point(111, 239);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(104, 23);
			this.btnEkle.TabIndex = 24;
			this.btnEkle.Text = "ROTA EKLE";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnGec
			// 
			this.btnGec.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGec.Location = new System.Drawing.Point(280, 239);
			this.btnGec.Name = "btnGec";
			this.btnGec.Size = new System.Drawing.Size(89, 23);
			this.btnGec.TabIndex = 24;
			this.btnGec.Text = "GEÇ";
			this.btnGec.UseVisualStyleBackColor = true;
			this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
			// 
			// lstRotalar
			// 
			this.lstRotalar.Dock = System.Windows.Forms.DockStyle.Right;
			this.lstRotalar.FormattingEnabled = true;
			this.lstRotalar.Location = new System.Drawing.Point(415, 0);
			this.lstRotalar.Name = "lstRotalar";
			this.lstRotalar.Size = new System.Drawing.Size(576, 317);
			this.lstRotalar.TabIndex = 25;
			// 
			// dtpKalkis
			// 
			this.dtpKalkis.Location = new System.Drawing.Point(237, 95);
			this.dtpKalkis.Name = "dtpKalkis";
			this.dtpKalkis.Size = new System.Drawing.Size(172, 20);
			this.dtpKalkis.TabIndex = 26;
			// 
			// dtpAraTarih
			// 
			this.dtpAraTarih.Location = new System.Drawing.Point(237, 138);
			this.dtpAraTarih.Name = "dtpAraTarih";
			this.dtpAraTarih.Size = new System.Drawing.Size(172, 20);
			this.dtpAraTarih.TabIndex = 26;
			// 
			// dtpVarisTarih
			// 
			this.dtpVarisTarih.Location = new System.Drawing.Point(237, 185);
			this.dtpVarisTarih.Name = "dtpVarisTarih";
			this.dtpVarisTarih.Size = new System.Drawing.Size(172, 20);
			this.dtpVarisTarih.TabIndex = 26;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FrmRotalar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(991, 317);
			this.Controls.Add(this.dtpVarisTarih);
			this.Controls.Add(this.dtpAraTarih);
			this.Controls.Add(this.dtpKalkis);
			this.Controls.Add(this.lstRotalar);
			this.Controls.Add(this.btnGec);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbVaris);
			this.Controls.Add(this.cmbAraLiman);
			this.Controls.Add(this.cmbGemiler);
			this.Controls.Add(this.cmbKalkis);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Name = "FrmRotalar";
			this.Text = "ROTALAR";
			this.Load += new System.EventHandler(this.FrmRotalar_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbVaris;
		private System.Windows.Forms.ComboBox cmbAraLiman;
		private System.Windows.Forms.ComboBox cmbKalkis;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbGemiler;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnGec;
		private System.Windows.Forms.ListBox lstRotalar;
		private System.Windows.Forms.DateTimePicker dtpKalkis;
		private System.Windows.Forms.DateTimePicker dtpAraTarih;
		private System.Windows.Forms.DateTimePicker dtpVarisTarih;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}