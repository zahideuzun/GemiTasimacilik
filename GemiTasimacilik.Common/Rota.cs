using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemiTasimacilik.Common
{
	public class Rota
	{
		public Gemi GemiAdi { get; set; }
		public DateTime KalkisTarihi { get; set; }
		public DateTime VarisTarihi { get; set; }
		public DateTime AraLimanTarih { get; set; }
		public string KalkisLiman { get; set; }
		public string AraLiman { get; set; }
		public string VarisLiman { get; set; }


		public override string ToString()
		{
			return string.Format(" {0} isimli gemi ile kalkış: {1} uğranacak: {2} varış: {3} Tarihler: {4} - {5}, ",
				GemiAdi, KalkisLiman, AraLiman, VarisLiman, KalkisTarihi, VarisTarihi);
		}
	}
}
