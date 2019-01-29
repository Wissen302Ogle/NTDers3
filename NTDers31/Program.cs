using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTDers31
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                int toplam = Int32.Parse(a) + Int32.Parse(b);
                Console.WriteLine(toplam);

            }

            catch (FormatException nesne)
            {
                Console.WriteLine("Hata nedeni: " + nesne.Message);


            }
            
            catch
            {
                Console.WriteLine("Tipsiz Catch");
            }

            finally
            {
                int t = 5;
                Console.WriteLine("Program Bitti");
                Console.ReadKey();
            }
        }
    }
}
