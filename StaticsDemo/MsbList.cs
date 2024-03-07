using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticsDemo
{
    internal class MsbList
    {
        public static int MaxElemanSayisi { get; set; }  //Eleman static yapılırsa, çağırıldığında bu elemana değer ataması yapılamaz. 
        public int ElemanSayisi { get;}

        public void Ekle(object eleman)
        {
            if (ElemanSayisi >= MaxElemanSayisi)
                throw new Exception("Liste Max eleman sayısına ulaşmıştır.");
        
        }
    }
}
