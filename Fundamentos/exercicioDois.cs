using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class exercicioDois {

        public static void Executar() {

            Console.WriteLine("Digite um numero!");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero!");
            double n2 = double.Parse(Console.ReadLine());

            double nn1 = (n1 * 3.5)/11;

            double nn2 = (n2 * 7.5)/11;



            Console.WriteLine($"Numeros que você digitou! \n 1º numero: {n1} \n 2º numero:{n2}");

            Console.WriteLine($"Numeros que registrou! \n 1º numero: {nn1.ToString("#,#")} \n 2º numero:{nn2.ToString("#,#")}");
        }
        }
}
