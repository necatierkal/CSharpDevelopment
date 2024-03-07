
//Anonim tipler var ile tanımlanır. Aşağıdaki örnekte verinin tipi yok tip belirtmeden custom bir öğrenci oluşturduk.
//Run time da veri tipi belirlediğimiz tipte oluşur. 
//Entity Frmaework ve delgelerde anonim tipler çok kullanılıyor.
//Object initiliazer yöntemiyl tanımlanır.
var ogrenci = new
{
    AdSoyad = "Salih DEMİROĞ",
    Yas = 20,
    Cinsiyet = 'E'
};


Console.WriteLine(ogrenci.GetType().FullName); //Oluşturduğumuz tipin ismini yazdırdığımızda anonymous type olarak görünür.
Console.WriteLine(ogrenci.AdSoyad); 
Console.WriteLine(ogrenci.Yas); 
Console.WriteLine(ogrenci.Cinsiyet);


var ogretmen = new
{
    AdiSoyadi = "Salih Demiroğ",
    Yas = 38,
    CalistigiOkul = new
    {
        Adi = "Gazi Üni",
        OgretimDurumu = "Lisans",
        Sehir = "Ankara"
    },
    VerilenDersler = new[]
    {
        new
        {
            Adi = "Programlama",
            KrediPuani = 3.0
        },
        new
        {
            Adi = "Tarih",
            KrediPuani = 1.5
        },
        new
        {
            Adi = "İngilizce",
            KrediPuani = 2.5
        }
    }
};


Console.WriteLine(ogretmen.CalistigiOkul.Adi);