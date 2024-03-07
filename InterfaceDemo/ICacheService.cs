using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface ICacheService
    {
        public void Add(string key, object data); //Interface içerisibideki metod imzaları c# 8.0 dan itibaren erişim belirtici alabilir hale geldi.
        public void Remove(string key);
        public object Get(string key);
        public bool isExist (string key); //Cache de bu data var mı?

        public void Clear (string key) //C# 8.0 'dan itibaren bu özellik geldi. Normalde interfacelerdeki metodlarda body kısmı mevcut değildi.
                                        //Kullanılacağı her sınıf için ortak bir özellik varsa bu kullanılabilir. Abstract metoda benziyor.
                                        //Metodun body'si olduğu için ınterface in miras alındığı class ta bu metot implemente edilmek zorunda değil.
                                        //Abstract tan farkı; abstract class kalıtımdan geçer, bu tamamlanmış metod interface in üzerinden türetilmiş class newlendiğinde erişilemez.
        {
            Console.WriteLine("Temizlendi.");
        }
    }
}
