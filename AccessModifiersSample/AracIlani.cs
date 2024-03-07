using AccessModifiersDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersSample
{
    internal class AracIlani : IlanBilgisi
    {
        public AracIlani()
        {
               //Private, Internal, Private protected erişilemez.
        }
    }
}
