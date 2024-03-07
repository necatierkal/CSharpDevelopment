using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    public class Okul
    {
     

        public string OkulAdi { get;set; }

        public string Sehir { get; set; }

        public string OgretimDurumu { get; set; }


    }

	public class Ders
	{
        public string Adi { get; set; }
        public double KrediPuani { get; set; }
    }

    internal class Ogrenci
    {
		private string _AdSoyad;

		public string AdSoyad
		{
			get { return _AdSoyad; }
			set { _AdSoyad = value; }
		}

		private int _Yas;

		public int Yas
		{
			get { return _Yas; }
			set { _Yas = value; }
		}

        public Okul Okul { get; set; }
        public List<Ders> Dersler { get; set; }




    }
}
