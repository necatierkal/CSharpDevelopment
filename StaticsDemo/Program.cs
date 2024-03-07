
using StaticsDemo;

var ortSonuc = MathHelper.OrtalamaAl(2,3); //Static class ve metod olduğu için instance oluşturulmadı. Direk çağırıldı.

var ortSonuc2 = MathHelper.OrtalamaAl(2, 3);
var ortSonuc3 = MathHelper.OrtalamaAl(2, 3);

var piSayisi = MathHelper.PiSayisiGetir;

MsbList.MaxElemanSayisi = 200;

var isimler = new MsbList();

isimler.Ekle("Salih");