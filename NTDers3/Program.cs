using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NTDers3
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
                Console.WriteLine("Hata...");
                

            }
            catch(IOException nesne)
            {
                Console.Write("hata...");
            }
            catch
            {
                Console.Write("Tipsiz Catch");
            }

            finally
            {
                int t = 5;
                Console.Write("Bitti");
                Console.ReadKey();
            }


        }
    }
}
