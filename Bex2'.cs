using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // ou mettre i=1
            while (i < 10)
            {
                Console.WriteLine("Bonjour, je suis le message N°" + (i + 1)); // enlever i+1
                i++;
            }
        }
    }
}
