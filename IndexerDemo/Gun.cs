using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    internal class Gun
    {
        private string[] _gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
        public string this[byte haftaninGunu]
        {
            get 
            {
                //switch (haftaninGunu)
                //{
                //    case 1:
                //        return "Pazartesi";
                //    case 2:
                //        return "Salı";
                //    case 3:
                //        return "Çarşamba";
                //    case 4:
                //        return "Perşembe";
                //    case 5:
                //        return "Cuma";
                //    case 6:
                //        return "Cumartesi";
                //    case 7:
                //        return "Pazar";
                //    default:
                //        throw new Exception("Haftanın günleri 1-7 arasında olmalıdır.");
                //}

                /*Yukarıdaki ve aşağıdaki ifade birbirinin ynısı. .NetCore ile gelen kısa yazım şekli aşağıda.*/
                //return haftaninGunu switch
                //{
                //    1 => "Pazartesi",
                //    2 => "Salı",
                //    3 => "Çarşamba",
                //    4 => "Perşembe",
                //    5 => "Cuma",
                //    6 => "Cumartesi",
                //    7 => "Pazar",
                //    _ => throw new Exception("Haftanın günleri 1-7 arasında olmalıdır."),
                //};

                /*Yukarıdaki yapının da daha kısası bir string array tanımlayıp aşağıdaki gibi aralık dışı değer exception ı kullanmaktır.*/

                if (haftaninGunu < 1 || haftaninGunu > 7)
                    throw new Exception("Haftanın günü 1-7 arasında olamlıdır.");
                return _gunler[haftaninGunu-1];   


            } /* return the specified index here */

        }
    }
}
