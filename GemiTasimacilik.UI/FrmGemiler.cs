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
	public partial class FrmGemiler : Form
	{
		ExtensionMethod extensionMethod = new ExtensionMethod();
		public FrmGemiler()
		{
			InitializeComponent();
		}

		private List<Gemi> gemiler = new List<Gemi>();
		private void btnEkle_Click(object sender, EventArgs e)
		{
			if (!(extensionMethod.NullValidator(tbGemiAdi.Text, numKapasite.Value.ToString())))
			{
				errorProvider1.SetError(tbGemiAdi, "Data alanları boş geçilemez!");
			}
			else
			{
				errorProvider1.Clear();

				lstGemiler.Items.Add(new Gemi() // bu islemin adi obj init
				{
					GemiAdi = tbGemiAdi.Text,
					Kapasite = (decimal)numKapasite.Value
				});
				MessageBox.Show("kayıt başarıldır.");
				Temizle();
			}
		}
		private void btnGec_Click(object sender, EventArgs e)
		{
			if (lstGemiler.Items.Count == 0)
			{
				MessageBox.Show("Data girmeden diğer ekrana geçemezsiniz!");
			}
			else
			{
				FrmRotalar frmDoktorlar = new FrmRotalar(VerileriListboxtanGetir());
				frmDoktorlar.Show();
			}
		}
		private void Temizle()
		{
			tbGemiAdi.Text = string.Empty;
			numKapasite.Value = 0;
		}

		private List<Gemi> VerileriListboxtanGetir() 
		{
			List<Gemi> gemiList = new List<Gemi>();
			foreach (Gemi item in  lstGemiler.Items)
			{
				gemiList.Add(item);
			}
			return gemiList;
		}
	}
}
