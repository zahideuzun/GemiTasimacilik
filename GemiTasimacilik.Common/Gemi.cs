using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemiTasimacilik.Common
{
	public class Gemi
	{
		public string GemiAdi { get; set; }
		public decimal Kapasite { get; set;}

		public override string ToString()
		{
			return GemiAdi.ToUpper();
		}
	}
}
