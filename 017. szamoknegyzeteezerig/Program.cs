using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.szamoknegyzeteezerig
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1001; i++)

            {
                Console.WriteLine("A(z) " + i + " négyzete: " + i * i);
            }

            Console.ReadKey();
        }
    }
}
