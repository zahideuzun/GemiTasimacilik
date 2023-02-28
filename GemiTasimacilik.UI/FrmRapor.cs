using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemiTasimacilik.Common;

namespace GemiTasimacilik.UI
{
	public partial class FrmRapor : Form
	{
		private List<Gemi> gemiler;
		private List<Yuk> musteriYuk;
		public FrmRapor(List<Gemi> gemiler)
		{
			this.gemiler = gemiler;
			InitializeComponent();
		}
		public FrmRapor(List<Gemi> gemiler, List<Rota> rotalar, List<Musteri> musteriler, List<Yuk> yukler)
		{
			this.gemiler = gemiler;
		}

		public FrmRapor(List<Gemi> gemiler, List<Yuk> musteriYuk) : this(gemiler)
		{
			this.gemiler = gemiler;
			this.musteriYuk = musteriYuk;
		}

		
		private void btnGemiAra_Click(object sender, EventArgs e)
		{
			listRapor.Items.Clear();
			int sayac = 1;

			foreach (Yuk item in musteriYuk)
			{
				if (item.YukRotasi.GemiAdi.GemiAdi == cmbGemiRapor.Text)
				{
					ListViewItem lv = new ListViewItem();
					lv.Text = (sayac++).ToString();
					lv.SubItems.Add(item.YukRotasi.GemiAdi.ToString());
					lv.SubItems.Add(item.YukRotasi.KalkisLiman);
					lv.SubItems.Add(item.YukRotasi.VarisLiman);
					lv.SubItems.Add(item.YukRotasi.KalkisTarihi.ToShortDateString());
					lv.SubItems.Add(item.YukRotasi.VarisTarihi.ToShortDateString());
					lv.SubItems.Add(item.TasitacagiYuk.ToString());
					lv.SubItems.Add(item.Musteri.SirketAdi);
					listRapor.Items.Add(lv);
				}
				
			}
		}
		private void FrmRapor_Load(object sender, EventArgs e)
		{
			Doldur();
		}

		void Doldur()
		{
			foreach (var item in gemiler)
			{
				cmbGemiRapor.Items.Add(item.GemiAdi);
			}
		}

		private void btnRotalar_Click(object sender, EventArgs e)
		{
			listRapor.Items.Clear();
			int sayac = 1;

			foreach (Yuk item in musteriYuk)
			{
				ListViewItem lv = new ListViewItem(); 
				lv.Text = (sayac++).ToString();
				lv.SubItems.Add(item.YukRotasi.GemiAdi.ToString());
				lv.SubItems.Add(item.YukRotasi.KalkisLiman);
				lv.SubItems.Add(item.YukRotasi.VarisLiman);
				lv.SubItems.Add(item.YukRotasi.KalkisTarihi.ToShortDateString());
				lv.SubItems.Add(item.YukRotasi.VarisTarihi.ToShortDateString());
				lv.SubItems.Add(item.TasitacagiYuk.ToString());
				lv.SubItems.Add(item.Musteri.SirketAdi);
				listRapor.Items.Add(lv);
			}


		}
	}
}
