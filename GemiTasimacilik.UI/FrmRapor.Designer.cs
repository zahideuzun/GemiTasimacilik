namespace GemiTasimacilik.UI
{
	partial class FrmRapor
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
			this.listRapor = new System.Windows.Forms.ListView();
			this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gemi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.kalkisLiman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.kalkisTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.varisLiman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.varisTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toplamYuk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.musteriGemi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.cmbGemiRapor = new System.Windows.Forms.ComboBox();
			this.btnGemiAra = new System.Windows.Forms.Button();
			this.btnRotalar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listRapor
			// 
			this.listRapor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.gemi,
            this.kalkisLiman,
            this.kalkisTarih,
            this.varisLiman,
            this.varisTarih,
            this.toplamYuk,
            this.musteriGemi});
			this.listRapor.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listRapor.HideSelection = false;
			this.listRapor.Location = new System.Drawing.Point(0, 87);
			this.listRapor.Name = "listRapor";
			this.listRapor.Size = new System.Drawing.Size(816, 286);
			this.listRapor.TabIndex = 0;
			this.listRapor.UseCompatibleStateImageBehavior = false;
			this.listRapor.View = System.Windows.Forms.View.Details;
			// 
			// no
			// 
			this.no.Text = "No";
			this.no.Width = 50;
			// 
			// gemi
			// 
			this.gemi.Text = "Gemi";
			this.gemi.Width = 125;
			// 
			// kalkisLiman
			// 
			this.kalkisLiman.Text = "Kalkış Limanı";
			this.kalkisLiman.Width = 99;
			// 
			// kalkisTarih
			// 
			this.kalkisTarih.DisplayIndex = 4;
			this.kalkisTarih.Text = "Kalkış Tarihi";
			this.kalkisTarih.Width = 90;
			// 
			// varisLiman
			// 
			this.varisLiman.DisplayIndex = 3;
			this.varisLiman.Text = "Varış Limanı";
			this.varisLiman.Width = 103;
			// 
			// varisTarih
			// 
			this.varisTarih.Text = "Varış Tarihi";
			this.varisTarih.Width = 85;
			// 
			// toplamYuk
			// 
			this.toplamYuk.Text = "Yük";
			this.toplamYuk.Width = 75;
			// 
			// musteriGemi
			// 
			this.musteriGemi.Text = "Müşteri";
			this.musteriGemi.Width = 190;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(55, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Gemi Ara";
			// 
			// cmbGemiRapor
			// 
			this.cmbGemiRapor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGemiRapor.FormattingEnabled = true;
			this.cmbGemiRapor.Location = new System.Drawing.Point(126, 30);
			this.cmbGemiRapor.Name = "cmbGemiRapor";
			this.cmbGemiRapor.Size = new System.Drawing.Size(200, 21);
			this.cmbGemiRapor.TabIndex = 3;
			// 
			// btnGemiAra
			// 
			this.btnGemiAra.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGemiAra.Location = new System.Drawing.Point(350, 30);
			this.btnGemiAra.Name = "btnGemiAra";
			this.btnGemiAra.Size = new System.Drawing.Size(75, 23);
			this.btnGemiAra.TabIndex = 4;
			this.btnGemiAra.Text = "ARA";
			this.btnGemiAra.UseVisualStyleBackColor = true;
			this.btnGemiAra.Click += new System.EventHandler(this.btnGemiAra_Click);
			// 
			// btnRotalar
			// 
			this.btnRotalar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRotalar.Location = new System.Drawing.Point(501, 28);
			this.btnRotalar.Name = "btnRotalar";
			this.btnRotalar.Size = new System.Drawing.Size(291, 23);
			this.btnRotalar.TabIndex = 4;
			this.btnRotalar.Text = "TÜM ROTALARI GETİR";
			this.btnRotalar.UseVisualStyleBackColor = true;
			this.btnRotalar.Click += new System.EventHandler(this.btnRotalar_Click);
			// 
			// FrmRapor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(816, 373);
			this.Controls.Add(this.btnGemiAra);
			this.Controls.Add(this.btnRotalar);
			this.Controls.Add(this.cmbGemiRapor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listRapor);
			this.Name = "FrmRapor";
			this.Text = "RAPOR";
			this.Load += new System.EventHandler(this.FrmRapor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listRapor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbGemiRapor;
		private System.Windows.Forms.Button btnGemiAra;
		private System.Windows.Forms.ColumnHeader no;
		private System.Windows.Forms.ColumnHeader gemi;
		private System.Windows.Forms.ColumnHeader kalkisLiman;
		private System.Windows.Forms.ColumnHeader kalkisTarih;
		private System.Windows.Forms.ColumnHeader varisLiman;
		private System.Windows.Forms.ColumnHeader varisTarih;
		private System.Windows.Forms.ColumnHeader toplamYuk;
		private System.Windows.Forms.ColumnHeader musteriGemi;
		private System.Windows.Forms.Button btnRotalar;
	}
}