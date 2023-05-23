using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class contador {
        public static void Executar() {

            Console.WriteLine("Digite um numero!");
            int valor = int.Parse(Console.ReadLine());

            int contador = 1;

            while (contador <= valor ) {

                Console.WriteLine(contador++);
            }
        }
    }
}
