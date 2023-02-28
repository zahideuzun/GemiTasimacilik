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
	public partial class FrmRotalar : Form
	{
		private ExtensionMethod extensionMethod = new ExtensionMethod();
		private List<Gemi> gemiler = new List<Gemi>();

		public FrmRotalar(List<Gemi> gemiler)
		{
			this.gemiler = gemiler;
			InitializeComponent();
		}

		private void FrmRotalar_Load(object sender, EventArgs e)
		{
			Doldur();
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			if (cmbGemiler.SelectedItem == null ||  cmbKalkis.SelectedItem ==  null || cmbAraLiman.SelectedItem == null || cmbVaris.SelectedItem == null)
			{
				errorProvider1.SetError(cmbGemiler, "Data alanları boş geçilemez!");
			}
			else
			{
				errorProvider1.Clear();
				lstRotalar.Items.Add(new Rota()
				{
					GemiAdi = cmbGemiler.SelectedItem as Gemi,
					KalkisLiman = cmbKalkis.SelectedItem.ToString(),
					AraLiman = cmbAraLiman.SelectedItem.ToString(),
					VarisLiman = cmbVaris.SelectedItem.ToString(),
					KalkisTarihi = dtpKalkis.Value,
					AraLimanTarih = dtpAraTarih.Value,
					VarisTarihi = dtpVarisTarih.Value
				});
				MessageBox.Show("rota eklendi");
				Temizle();
			}
		}
		private void btnGec_Click(object sender, EventArgs e)
		{
			if (lstRotalar.Items.Count == 0)
			{
				MessageBox.Show("Tüm verileri girmeden diğer forma geçiş yapamazsınız.. ");
			}
			else
			{
				FrmMusteriBilgileri frm = new FrmMusteriBilgileri(VerileriListboxtanOku(), gemiler);
				frm.Show();
			}
		}
		/// <summary>
		/// daha kısa nasil yazilir? 
		/// </summary>
		/// <returns></returns>
		public List<Rota> VerileriListboxtanOku()
		{
			List<Rota> listem = new List<Rota>();

			//return lstRotalar.Items.Cast<Rota>().ToList().ForEach(x => listem.Add(x));
			
			foreach (Rota item in lstRotalar.Items)
			{
				listem.Add(item);
			}
			return listem;
		}

		public void Doldur()
		{
			foreach (Gemi item in gemiler)
			{
				cmbGemiler.Items.Add(item);
			}
		}
		private void Temizle()
		{
			cmbGemiler.SelectedItem = cmbKalkis.SelectedItem = cmbAraLiman.SelectedItem = cmbVaris.SelectedItem = null;
			//dtpKalkis.Value = dtpVarisTarih.Value = dtpAraTarih.Value = DateTime.Parse("0");
		}
	}
}
