using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTDers35
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine(3 / a);
            }
            catch (Exception nesne)//Bu blok en sonda kullanılmalı.
            {
                Console.WriteLine("Hata var!");
            }
            //Yukarıda Expection kullanıldığı için DivideByZeroException kullanılmasına izin vermiyor.
            /*catch (DivideByZeroException nesne)
            {
                Console.WriteLine("Sayı sıfıra bölünmez!");
            }*/
        }
    }
}
