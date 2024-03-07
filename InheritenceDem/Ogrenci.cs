using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{

    internal class Kisi
    {
        public string AdiSoyadi { get; set; }
        public int Yas { get; set; }
        public string TcNo { get; set; }
    }
    internal class Ogrenci : Kisi
    {
        public string OkulNo { get; set; }
    }

    internal class Ogretmen : Kisi
    {
       public decimal Maas { get; set;}

    }

    internal sealed class BasariliOgretmen : Ogretmen //sealed keyword'ü ilgili classı base class olarak kullanılmasına engel olur.
    {
        public decimal Prim { get; set; }

    }


}
