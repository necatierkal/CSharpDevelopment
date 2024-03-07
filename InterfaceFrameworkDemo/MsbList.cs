using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFrameworkDemo
{
    internal class MsbList : IMsbList //Bir sınıf istenilen kadar interface ten miras alabilir. Multiple inheritance 
        //Miras alırken varsa önce sınıf yazılır sonra interface ler sıralanarak miras alınır.
        //Interface lerle çalışırken değeri dışarıdan parametreyle almak önemli. Interface i implemnte eden class tan oluşrulan nesneye bağımlılığı ortadan kaldıır.
        //Bu design patterne dependency injection denir. (Soyut bir nesne implemente eden class tan constructor vasıtasıyla bağımlılığı azaltmak)
        // Oluşan class yine de newlenmek zorunda. Bunları merkezi bir yerden yönetip değişiklik yapmaya da IOC denir.

    {
        private object[] _dizi ;
        public MsbList()
        {
            _dizi = new object[0];
        }
        public object this[int index]
        { 
            get => _dizi[index]; 
            set => _dizi[index]= value; 
        }

        public int ElemanSayisi => _dizi.Length;

        public void Ekle(object eleman)
        {
            var yedekDizi = _dizi;  
            _dizi = new object[ElemanSayisi + 1];
            yedekDizi.CopyTo(_dizi, 0);
            _dizi[ElemanSayisi-1] = eleman;
        }

        public void Sil(int indexNo)
        {
            var yedekDizi = _dizi;
            _dizi = new object[ElemanSayisi - 1];
            int sayac = 0;
            for (int i = 0; i < yedekDizi.Length; i++)
            {
                if (indexNo == i)
                    continue;
              
                _dizi[sayac] = yedekDizi[i];
                sayac++;    
            }
        }
    }
}
