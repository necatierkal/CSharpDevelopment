

using PolymorphismDemo;

//var ogrenci = new Ogrenci
//{
//    AdSoyad = "Salih DEMİROĞ",
//    Yas = 24
//};
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



string ifade = ogrenci.ToString();

Console.WriteLine(ifade);

ogrenci.BilgilerYazdir();
ogretmen.BilgilerYazdir();
