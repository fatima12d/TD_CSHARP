using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_a_rendre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donner le montant des dommages :");
            double montant = double.Parse(Console.ReadLine());
            Console.WriteLine("le montant est :" + montant);
            double franc = (montant * 10) / 100;
            if( franc <=4000 ) {
                montant -= franc;
                Console.WriteLine("le montant a rembourser est :" + montant);
                Console.WriteLine("la franchise est de :" + franc);
            }
            else
            {
                montant -= 4000;
                Console.WriteLine("le montant a rembourser est :" + montant);
                Console.WriteLine("la franchise est de :" + 4000);

            }

            Console.ReadKey();

        }
    }
}
