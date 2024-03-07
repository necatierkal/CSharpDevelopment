//Indexer lar kullanılan snıflara index yeteneği kazandırmak için oluşturulur. Bir sınıfa bir tane indexer tanımlanabilir.
//Çünkğ this ifadesi ile kullanılmalıdır. This ifadesi classı ifade eder.


using IndexerDemo;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

ArrayList list = new ArrayList() { 10,22.33};
Gun gun = new Gun();

list[0] = 11;
var ilkEleman = list[0];


string haftaninIlkGunu = gun[1];

Console.WriteLine(haftaninIlkGunu);
