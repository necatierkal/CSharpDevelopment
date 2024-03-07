
////Soyut bir classtır. Interface gibidir fakat onlarda olmayan constructor ve field tanımlama özelliğini normalbir class gibi sağlar. Ortak kullanılacak

using AbstractClassDemo;

///özellikler abstract class vasıtasıyla yazılabilir.

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

ogrenci.BilgileriYazdir();
ogretmen.BilgileriYazdir(); 