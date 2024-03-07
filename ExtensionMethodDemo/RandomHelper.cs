using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    #region ExtensionAciklama
    // Extension yazılacak class static olmalıdır.
    #endregion

    public static class RandomHelper
    {
        public static int TekSayiUret(this Random random, int min, int max) /// Random sınıfının içeisinden gelmesi ve bundan instance oluşturabilmesi için metodun içine yazdık.
                                                                            /// Buradaki this önemlidir. Random sınıfından üretilen this i kendisi alır. 
        {
            
            var randomSayi = random.Next(min, max); 

            if (randomSayi%2 == 0)
                return randomSayi+1;

            return randomSayi;
        }

        public static int ToInt32(this object obj)
        {
            return Convert.ToInt32(obj);   
        }
    }
}
