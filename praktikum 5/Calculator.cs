using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_5
{
    public class Calculator
    {

        public int CariNilai(int a, int b, int c)
        {
            int min;
            if (a < b)
            {
                Console.WriteLine("Nilai min dari ketiga nilai adalah : {0}", min = a);
                Console.ReadKey();
            }
            else if (b < c)
            {
                Console.WriteLine("Nilai min dari ketiga nilai adalah : {0}", min = b);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nilai min dari ketiga nilai adalah : {0}", min = c);
                Console.ReadKey();
            }
            return min;
        }
    }
    public class Calkulator
    {
        public int CariNilai(int a, int b, int c)
        {
            int max;
            if (a > b)
            {
                Console.WriteLine("Nilai max dari ketiga nilai adalah : {0}", max = a);
                Console.ReadKey();
            }
            else if (b > c)
            {
                Console.WriteLine("Nilai max dari ketiga nilai adalah : {0}", max = b);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nilai max dari ketiga nilai adalah : {0}", max = c);
                Console.ReadKey();
            }
            return max;
        }
    }
}
