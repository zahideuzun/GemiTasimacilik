namespace GemiTasimacilik.UI
{
	partial class FrmMusteriBilgileri
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
			this.tbSirketAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbAdres = new System.Windows.Forms.TextBox();
			this.cmbBulunanSeferler = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAra = new System.Windows.Forms.Button();
			this.cmbVarisLimani = new System.Windows.Forms.ComboBox();
			this.cmbKalkisLimanı = new System.Windows.Forms.ComboBox();
			this.numTasinacakYuk = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbMusteriAdi = new System.Windows.Forms.TextBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.dtpMusteriTarih = new System.Windows.Forms.DateTimePicker();
			this.mtbVergi = new System.Windows.Forms.MaskedTextBox();
			this.btnGec = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numTasinacakYuk)).BeginInit();
			this.SuspendLayout();
			// 
			// tbSirketAdi
			// 
			this.tbSirketAdi.Location = new System.Drawing.Point(589, 31);
			this.tbSirketAdi.Name = "tbSirketAdi";
			this.tbSirketAdi.Size = new System.Drawing.Size(121, 20);
			this.tbSirketAdi.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(445, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Şirket Adı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(445, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Vergi Numarası";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(445, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Şirket Adresi:";
			// 
			// tbAdres
			// 
			this.tbAdres.Location = new System.Drawing.Point(589, 105);
			this.tbAdres.Multiline = true;
			this.tbAdres.Name = "tbAdres";
			this.tbAdres.Size = new System.Drawing.Size(121, 98);
			this.tbAdres.TabIndex = 3;
			// 
			// cmbBulunanSeferler
			// 
			this.cmbBulunanSeferler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBulunanSeferler.FormattingEnabled = true;
			this.cmbBulunanSeferler.Location = new System.Drawing.Point(183, 237);
			this.cmbBulunanSeferler.Name = "cmbBulunanSeferler";
			this.cmbBulunanSeferler.Size = new System.Drawing.Size(121, 21);
			this.cmbBulunanSeferler.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(22, 237);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 17);
			this.label5.TabIndex = 27;
			this.label5.Text = "Bulunan Gemiler";
			// 
			// btnAra
			// 
			this.btnAra.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAra.Location = new System.Drawing.Point(124, 181);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(103, 29);
			this.btnAra.TabIndex = 26;
			this.btnAra.Text = "GEMİ ARA";
			this.btnAra.UseVisualStyleBackColor = true;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// cmbVarisLimani
			// 
			this.cmbVarisLimani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVarisLimani.FormattingEnabled = true;
			this.cmbVarisLimani.Items.AddRange(new object[] {
            "İZMİR",
            "İSTANBUL",
            "ADANA",
            "İSKENDERUN",
            "TRABZON",
            "MERSİN"});
			this.cmbVarisLimani.Location = new System.Drawing.Point(183, 101);
			this.cmbVarisLimani.Name = "cmbVarisLimani";
			this.cmbVarisLimani.Size = new System.Drawing.Size(150, 21);
			this.cmbVarisLimani.TabIndex = 24;
			// 
			// cmbKalkisLimanı
			// 
			this.cmbKalkisLimanı.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKalkisLimanı.FormattingEnabled = true;
			this.cmbKalkisLimanı.Items.AddRange(new object[] {
            "İZMİR",
            "İSTANBUL",
            "ADANA",
            "İSKENDERUN",
            "TRABZON",
            "MERSİN"});
			this.cmbKalkisLimanı.Location = new System.Drawing.Point(183, 72);
			this.cmbKalkisLimanı.Name = "cmbKalkisLimanı";
			this.cmbKalkisLimanı.Size = new System.Drawing.Size(150, 21);
			this.cmbKalkisLimanı.TabIndex = 23;
			// 
			// numTasinacakYuk
			// 
			this.numTasinacakYuk.Location = new System.Drawing.Point(183, 134);
			this.numTasinacakYuk.Name = "numTasinacakYuk";
			this.numTasinacakYuk.Size = new System.Drawing.Size(150, 20);
			this.numTasinacakYuk.TabIndex = 22;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(13, 47);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 17);
			this.label6.TabIndex = 17;
			this.label6.Text = "Tarih";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(12, 134);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(153, 17);
			this.label7.TabIndex = 18;
			this.label7.Text = "Toplam Taşıanacak Yük";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(12, 101);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(106, 17);
			this.label8.TabIndex = 19;
			this.label8.Text = "Gidilecek Liman";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(12, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 17);
			this.label9.TabIndex = 20;
			this.label9.Text = "Başlangıç Limanı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(445, 215);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 19);
			this.label4.TabIndex = 2;
			this.label4.Text = "İlgili Kişi:";
			// 
			// tbMusteriAdi
			// 
			this.tbMusteriAdi.Location = new System.Drawing.Point(589, 216);
			this.tbMusteriAdi.Name = "tbMusteriAdi";
			this.tbMusteriAdi.Size = new System.Drawing.Size(121, 20);
			this.tbMusteriAdi.TabIndex = 3;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.Location = new System.Drawing.Point(473, 257);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(103, 29);
			this.btnKaydet.TabIndex = 25;
			this.btnKaydet.Text = "KAYDET";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// dtpMusteriTarih
			// 
			this.dtpMusteriTarih.Location = new System.Drawing.Point(183, 43);
			this.dtpMusteriTarih.Name = "dtpMusteriTarih";
			this.dtpMusteriTarih.Size = new System.Drawing.Size(150, 20);
			this.dtpMusteriTarih.TabIndex = 29;
			// 
			// mtbVergi
			// 
			this.mtbVergi.Location = new System.Drawing.Point(589, 69);
			this.mtbVergi.Mask = "0000000000";
			this.mtbVergi.Name = "mtbVergi";
			this.mtbVergi.Size = new System.Drawing.Size(121, 20);
			this.mtbVergi.TabIndex = 30;
			this.mtbVergi.ValidatingType = typeof(int);
			// 
			// btnGec
			// 
			this.btnGec.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGec.Location = new System.Drawing.Point(606, 257);
			this.btnGec.Name = "btnGec";
			this.btnGec.Size = new System.Drawing.Size(89, 29);
			this.btnGec.TabIndex = 31;
			this.btnGec.Text = "GEÇ>>";
			this.btnGec.UseVisualStyleBackColor = true;
			this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
			// 
			// FrmMusteriBilgileri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(755, 308);
			this.Controls.Add(this.btnGec);
			this.Controls.Add(this.mtbVergi);
			this.Controls.Add(this.dtpMusteriTarih);
			this.Controls.Add(this.cmbBulunanSeferler);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.btnAra);
			this.Controls.Add(this.cmbVarisLimani);
			this.Controls.Add(this.cmbKalkisLimanı);
			this.Controls.Add(this.numTasinacakYuk);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbMusteriAdi);
			this.Controls.Add(this.tbAdres);
			this.Controls.Add(this.tbSirketAdi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmMusteriBilgileri";
			this.Text = "MÜŞTERİ SATIŞ";
			((System.ComponentModel.ISupportInitialize)(this.numTasinacakYuk)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbSirketAdi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbAdres;
		private System.Windows.Forms.ComboBox cmbBulunanSeferler;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.ComboBox cmbVarisLimani;
		private System.Windows.Forms.ComboBox cmbKalkisLimanı;
		private System.Windows.Forms.NumericUpDown numTasinacakYuk;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbMusteriAdi;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.DateTimePicker dtpMusteriTarih;
		private System.Windows.Forms.MaskedTextBox mtbVergi;
		private System.Windows.Forms.Button btnGec;
	}
}