using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator1 = new Calculator();
            Calkulator calculator2 = new Calkulator();
            Console.Write(calculator1.CariNilai(6, 4, 5));
            Console.Write(calculator2.CariNilai(7, 5, 3));  
            Console.ReadKey();
        }
    }
}
