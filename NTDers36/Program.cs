using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTDers36
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 300;
            try
            {
                checked
                {

                    unchecked
                    {
                        byte sayiByte1 = (byte)sayi;
                        Console.WriteLine(sayiByte1.ToString());
                    }

                    byte sayiByte2 = (byte)sayi;
                    Console.WriteLine(sayiByte2.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
