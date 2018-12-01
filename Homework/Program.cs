using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Random nrRandom = new Random();
            int number = nrRandom.Next(0, 100);

            int nrIntrodus;

            do
            {
                Console.WriteLine("Introduceti numarul: ");
                nrIntrodus = int.Parse(Console.ReadLine());

                if (nrIntrodus < number)
                {
                    Console.WriteLine("Numarul introdus este mai mic decat numarul generat.");
                    Console.WriteLine();
                }

                else if (nrIntrodus == number)
                {
                    Console.WriteLine("Ati ghicit numarul!\nNumarul era " + number);
                }

                else if (nrIntrodus > number)
                {
                    Console.WriteLine("Numarul introdus este mai mare decat numarul generat.");
                    Console.WriteLine();
                }

            } while (nrIntrodus != number);

            Console.ReadKey();

        }
    }
}
