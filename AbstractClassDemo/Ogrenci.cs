using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    //İsimlendirme standardına göre abstract sınıf isimlerinin sonun Base eklenir. KisiBase gibi
    /// <summary>
    /// Bir sınıf maksimum bir abstract sınıftan inherit edilebilr. (Normal class gibi davranır.)
    /// </summary>
    internal abstract class Kisi // Soyut sınıf oldu. Artık new lenemez.Kendisinin kullanılmasını istiyorsak class (new lenebilir.) istemiyorsak abstract yaparız. Kişi örneği.
    {
        private int sayi = 0;
        protected Kisi() //// Public de yazsak protected in üzerine çıkamaz. Interface ve static ten farkı bu.
                      //// Static yaparsak kalıtımda kullanamayız. o yüzden abstract kullanırız. (Singleton design pattern-private yaparsak)
        {
                
        }
        public string AdiSoyadi { get; set; }
        public int Yas { get; set; }
        public string TcNo { get; set; }

        public abstract string Meslek { get; }

        #region Bilgi Yazdır
     
        public void BilgileriYazdir()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Adı Soyadı : {0}", AdiSoyadi);
            Console.WriteLine("Yaş : {0}", Yas);
            Console.WriteLine("TcNo : {0}", TcNo);
            Console.WriteLine("Mesleği : {0}", Meslek);
            EkstraBilgileriYazdir();
        }
        #endregion
        protected abstract void EkstraBilgileriYazdir();

    }
    internal class Ogrenci : Kisi
    {
        public string OkulNo { get; set; }

        public override string Meslek => "Öğrenci";

        protected override void  EkstraBilgileriYazdir()
        {
            Console.WriteLine("Okul No : {0}", OkulNo);
        }
    }

    internal class Ogretmen : Kisi
    {
        public decimal Maas { get; set;}

        public override string Meslek => "Öğretmen";

        protected override void EkstraBilgileriYazdir()
        {
            Console.WriteLine("Maaş : {0}", Maas);
        }

    }



}
