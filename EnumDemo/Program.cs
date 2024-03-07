
using EnumDemo;

var ogrenci = new Ogrenci
{
    AdiSoyadi = "Necati ERKAL",
    Yas = 20,
    Okul = new Okul
    {
        Adi = "Gazi Uni",
        Sehir = "Ankara",
        OgretimDurumu = OgretimDurumuEnum.Lisans
    }
};

Console.WriteLine( ogrenci.Okul.OgretimDurumu );
Console.WriteLine((int)ogrenci.Okul.OgretimDurumu); //Sayısal karşılığını verir ==> 3
Console.WriteLine(ogrenci.Okul.OgretimDurumu.GetHashCode()); //Sayısal karşılığını verir ==> 3
Console.WriteLine(ogrenci.Okul.OgretimDurumu.ToString("d"));//"3"
Console.WriteLine(ogrenci.Okul.OgretimDurumu.ToString("g"));//"Lisans"
Console.WriteLine(ogrenci.Okul.OgretimDurumu.ToString("x")); //"000003"
Console.WriteLine(ogrenci.Okul.OgretimDurumu.ToString());//tostring in defult format değeri "g" dir. Bu formatlanabilir d-->  digit,  x--> hexcadecimal formatları verilebilir.
                                                         // içeride formatlamak istediğimiz formata çevirir (hexadecimal gibi) dışa string olarak verir. Farklı çeşitleri de mevcut. (b, n,p,...gibi)


Console.WriteLine("-------------------------------------------------------------------");

Renk renk = Renk.Sari;
renk = Renk.Kirmizi;

Renk turuncu = Renk.Sari | Renk.Kirmizi; // Enumlar birden fazla enum değeri alabilir. 

Console.WriteLine($"renk: {renk}, int değeri : {(int)renk}");
Console.WriteLine($"renk: {turuncu}, int değeri : {(int)turuncu}"); //index değeri büyük olanın index değerini basar. metinsel sonuç vermez.


var renkler = Enum.GetNames<Renk>(); //Enum da tanımlı elemanların isimlerini string array olarak döndürür. GetNames-------> string array döner
var renkler2 = Enum.GetValues<Renk>(); //Enum da tanımlı elemanların isimlerini string array olarak döndürür. GetValues -------> renk array  döner

Console.WriteLine(string.Join(",",renkler)); // araya virgül ekleyerek tüm array i yazdırır. 