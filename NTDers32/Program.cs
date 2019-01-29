using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTDers32
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception ex = new Exception();
            
            try
            {
                Metot();
                int[] b = new int[4];
                Console.WriteLine(b[5]);
            }
            catch (Exception nesneMain)
            {
                Console.WriteLine("Metodu kullananda hata yakalandı"+ "\n"+nesneMain.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }
        static void Metot()
        {
            try
            { 
            int[] a = new int[2];
            Console.WriteLine(a[3]);
            }
            catch(IndexOutOfRangeException nesneMetot)
            {
                Console.WriteLine("Metodun kendisinde hata yakalandı");
            }


        }
    }
}
