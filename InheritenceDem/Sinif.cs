using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class A
    {
        public A()
        {
            Console.WriteLine("A Ctor Çalıştı");
        }
        public A(object obj)
        {
            Console.WriteLine("A1 Ctor Çalıştı");
        }
    }
    internal class B : A
    {
        public B()
        {
            Console.WriteLine("B Ctor Çalıştı");
        }
        public B(object obj)
        {
            Console.WriteLine("B1 Ctor Çalıştı");
        }
    }  
    internal class C : B
    {
        public C()
        {
            Console.WriteLine("C Ctor Çalıştı");
        }
        public C(object obj) : base(obj) //------>> class b deki parametreli constructor'ı çalıştır.
        {
            Console.WriteLine("C1 Ctor Çalıştı");
        }
    }

    /////Parametreli olarak çalıştırmak isteseydik iligili türeyen class ta parametreli constructor a base keyword ile tanımlama yapmalıyı.
    ///    public C(object obj) : base (obj) -------->>> türediği sınıfın parametreli constructor'ını çalıştır.
        //{
        //    Console.WriteLine("C1 Ctor Çalıştı");
        //}

    ///base ---> türediği sınıfın insctance'ı
    ///this ----> bulunduğu sınıfın instance'ını belirtir.

}
