

/*
 * 
 * Access Modifiers 4 adettir.
private   ----> Bulunduğu scope'tan erişilir.
protected ----> Tanımlandığı sınıftan ve türemiş sınıftan erişilebilir. Kalıtılabilir. (Aynı assembly veya farklı assembly olması farketmez kalıtılırsa erişilir.)
internal  ----> Tanımlandığı projede (Assembly'den) erişilebilir. (Class larda access modifier belirtilmezse default'u internal olur.)
public    ----> Tanımlandığı assembly dışında kalan farklı assembly'lerden de erişilir. 

2 durumda birlikte kullanılır;
protected internal  ----> Aynı assembly'de kalıtmadan da erişebilmek için kullanılır. Farklı assembly'de türetilirse erişilir.
private protected   ----> C# 7.2 'te geldi. Farklı Assembly'de protected bir nesneye erişilmesi istenmiyorsa bu kullanılır. Sadece bulunulan assembly'de kalıtımdan geçmesi için kullanılır.




 
 */



using AccessModifiersDemo;

var ilanBilgii = new IlanBilgisi
{
    // Private, Protected, PrivateProtected erişilemedi.

};

var konutIlani = new KonutIlanBilgisi
{
    // Private, Protected, PrivateProtected erişilemedi.

};