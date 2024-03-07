using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFrameworkDemo
{
    internal class Program
    {
        //Bu proje . net framework 4.7.2 c#8.0 öncesi için geçerli.
        //Interface ler soyut nesnelerdir ve soyut nesneler new lenemez.
        //normal class lar somuttur, abstract ve interface ler soyuttur.
        //Kalıtım yoluyla kullanılabilirler ve kalıtıldığı sınıf implemente edildikten sonra tüm metodlar içerisinde barındırmalıdır.
        //Interface ler tamamlanmış yani bir işi yapan metod barıdıramaz.
        //Bir interface'in 4 üyesi olabilir : metod , property , indexer ve event
        //Soyut bir veri tipidir.
        static void Main(string[] args)
        {
            var msbList = new MsbList();
            msbList.Ekle("Salih");
            msbList.Ekle("Mustafa");
            msbList.Ekle("Engin");
            msbList.Ekle("Zeynep");

            Console.WriteLine("Eleman Sayısı : {0}", msbList.ElemanSayisi);

            var ilkKayit = msbList[0];

            msbList[2] = "Gözde";

            msbList.Sil(1);

            for (int i = 0; i < msbList.ElemanSayisi; i++)
            {
                Console.WriteLine(msbList[i]);
            }

            Console.ReadLine();
        }
    }
}
