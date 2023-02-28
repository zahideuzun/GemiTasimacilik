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
	public partial class FrmMusteriBilgileri : Form
	{
		List<Yuk> musteriYuk = new List<Yuk>();
		private List<Gemi> gemiler = new List<Gemi>();
		private List<Rota> rotalar = new List<Rota>();
		List<Musteri> musteri = new List<Musteri>();

		public FrmMusteriBilgileri()
		{
			InitializeComponent();
		}

		public FrmMusteriBilgileri(List<Rota> rotas, List<Gemi> gemiler) : this()
		{
			this.rotalar = rotas;
			this.gemiler = gemiler;
		}

		private void btnAra_Click(object sender, EventArgs e)
		{
			cmbBulunanSeferler.Items.Clear();
			bool varMi = false;
			foreach (Rota item in rotalar)
			{
				if (item.KalkisLiman == cmbKalkisLimanı.SelectedItem.ToString()
					&& item.KalkisTarihi.ToShortDateString() == dtpMusteriTarih.Value.ToShortDateString() || item.AraLiman == cmbVarisLimani.SelectedItem.ToString()
					&& (item.VarisLiman == cmbVarisLimani.SelectedItem.ToString())
					&& TonajKontroluYap(item.GemiAdi.GemiAdi))
				{
					cmbBulunanSeferler.Items.Add(item);
					varMi = true;
					//break;
				}
			}
			if (!varMi)
			{
				cmbBulunanSeferler.SelectedItem = -1;
				MessageBox.Show("uygun kriterde bir seferimiz bulunmamaktadır.");
			}
		}

		private bool TonajKontroluYap(string gemiAdi)
		{
			cmbBulunanSeferler.Items.Clear();
			foreach (Gemi item in gemiler.Where(x=>x.GemiAdi== gemiAdi))
			{
				if (item.Kapasite >= numTasinacakYuk.Value)
				{
					return true;
				} 
			}
			return false;
		}

		void KapasiteAzalt()
		{
			//var gemi = gemiler.FirstOrDefault(x => x.GemiAdi == cmbBulunanSeferler.SelectedItem);
			var gemi = gemiler.Where(x => x.GemiAdi == cmbBulunanSeferler.SelectedItem).ToList();
			foreach (Gemi item in gemi)
			{
				item.Kapasite = (item.Kapasite - numTasinacakYuk.Value);
			}
			//gemi.Kapasite= (gemi.Kapasite - numTasinacakYuk.Value);
		}
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			KapasiteAzalt();
			musteriYuk.Add(new Yuk()
			{
				IslemTarihi = DateTime.Now,
				YukRotasi = cmbBulunanSeferler.SelectedItem as Rota,
				TasitacagiYuk = double.Parse(numTasinacakYuk.Text),
				Musteri = new Musteri()
				{
					Adresi = tbAdres.Text,
					MusteriAdiSoyad = tbMusteriAdi.Text,
					SirketAdi = tbSirketAdi.Text,
					//MusteriTemsilciAdSoyadBilgisi
					VergiNumarasi = long.Parse(mtbVergi.Text)

				}
			});
			MessageBox.Show("Yük seçilen gemiye kaydedildi!");
			Temizle();
			//cmbBulunanSeferler.Items.Clear();
			//cmbBulunanSeferler.SelectedItem = -1;
		}

		private void btnGec_Click(object sender, EventArgs e)
		{
			FrmRapor frm = new FrmRapor(gemiler,musteriYuk);
			frm.Show();
		}

		void Temizle()
		{
			cmbKalkisLimanı.SelectedItem = cmbBulunanSeferler.SelectedItem = cmbVarisLimani.SelectedItem = tbSirketAdi.Text= tbAdres.Text=tbMusteriAdi.Text = mtbVergi.Text= null;
			numTasinacakYuk.Value = 0;
			
		}
	}
}
