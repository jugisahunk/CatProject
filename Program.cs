using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat purra = new Cat();

            Console.WriteLine(purra.Pur());

            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(purra.Pet());

                Console.ReadLine();
            }
        }
    }
}
