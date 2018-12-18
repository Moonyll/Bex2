using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre;
            for (nombre = 0; nombre < 10; nombre++)
            {
                Console.WriteLine("Bonjour, je suis le message N° "+ (nombre+1));
            }
        }
    }
}
