using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{


        internal class Kisi
        {
            public string AdiSoyadi { get; set; }
            public virtual int Yas { get; set; } //Propertyler de virtual yapılıp override edilebilir.
            public string TcNo { get; set; }
            public virtual void BilgilerYazdir() ///override edilebilmesi için virtual eklenmeli.
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Adı Soyadı : {0}", AdiSoyadi); //this yazmaya gerek yok,karışacak bir durum yok
                Console.WriteLine("Yaş : {0}", Yas);
                Console.WriteLine("TcNo : {0}", TcNo);
            }

        }
        internal class Ogrenci : Kisi
        {
            public string OkulNo { get; set; }
            public override string ToString()
            {
                return$"{AdiSoyadi}- {Yas}" ;
            }
            public override void BilgilerYazdir() 
            { 
                base.BilgilerYazdir();
                Console.WriteLine("Okul No :",OkulNo);
            }

        }

        internal class Ogretmen : Kisi
        {
            public decimal Maas { get; set; }
            public override void BilgilerYazdir()
            {
                base.BilgilerYazdir();
                Console.WriteLine("Maaş Bilgisi:",Maas);
            }
            public override int Yas 
            { get => base.Yas;
              set 
              {
                  if (value < 18)
                      throw new Exception("Öğretmenin yaşı 18 den küçük olamaz.");
                  base.Yas = value;   
              }
            }

    }

        internal sealed class BasariliOgretmen : Ogretmen //sealed keyword'ü ilgili classı base class olarak kullanılmasına engel olur.
        {
            public decimal Prim { get; set; }

        }

}
