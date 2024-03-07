using InheritanceDemo;

var ogrenci = new Ogrenci()
{
    AdiSoyadi = "Zeynep Liya",
    OkulNo = "5",
    TcNo = "23232432342",
    Yas = 18
};

var ogretmen = new Ogretmen()
{
    AdiSoyadi = "Salih DEMİROĞ",
    TcNo = "23232432342",
    Yas = 38,
    Maas = 65_000
};


var kisi = new Kisi();
bool isKisi = ogretmen is Kisi; //true
bool isBasarliOgretmen = ogretmen is BasariliOgretmen; //false

BilgileriYazdir(ogretmen);
BilgileriYazdir(ogrenci);

var c = new C(); //çıktı : a-b-c 
var c1 = new C("Salih"); //çıktı : a-b-c1

static void BilgileriYazdir(Kisi kisi)
{
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine("Adı Soyadı : {0}",kisi.AdiSoyadi);
    Console.WriteLine("Yaş : {0}",kisi.Yas);
    Console.WriteLine("TcNo : {0}",kisi.TcNo);

    ////#c# 6.0 da bu kullanım geldi
    ///aşağıdaki if bloğu şu şekilde de yazılabilirdi:
    ///if ( kisi is Ogrenci ogrencim)
    ///       Console.WriteLine("Okul No: {0}", ogrencim.OkulNo);

    if (kisi is Ogrenci) 
    {
        var ogrencim = (Ogrenci)kisi;
        Console.WriteLine("Okul No: {0}", ogrencim.OkulNo);
    }
    //else if (kisi is Ogretmen)
    //{
    //    var ogretmenim = (Ogretmen)kisi;    
    //    Console.WriteLine("Ogretmen Maaşı : {0}",ogretmenim.Maas);    
    //}

    Ogretmen ogretmenim = kisi as Ogretmen; // kişiyi öğretmene dönüştürür. Dönüştüremezse hata vermez. Null a dönüştürür.
                                            // Bunu yazdırmaya veya kullanmaya kalkarsak null referans hatası alırız. Ama burada patlatmaz.Bu atamadan sonra bu nesne kullanılacaksa 
                                            //null kontrolü yapılmalı.


    if (ogretmenim != null) // Burada da is null ya da is not null denebilir. .Net 6.0 'dan itibaren (ogretmenim is null),  .Net 9.0 'dan itibaren (ogretmenim is not null)
        Console.WriteLine("Maas : {0}" , ogretmenim.Maas);
}