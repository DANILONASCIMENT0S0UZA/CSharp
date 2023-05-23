using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class Tabuada {

        public static void Executar() {

            Console.WriteLine("Digite um numero para saber a tabuada dele!");
            int cont = int.Parse(Console.ReadLine());

            Console.WriteLine($"{cont} X 1 = {cont * 1}");
            Console.WriteLine($"{cont} X 2 = {cont * 2}");
            Console.WriteLine($"{cont} X 3 = {cont * 3}");
            Console.WriteLine($"{cont} X 4 = {cont * 4}");
            Console.WriteLine($"{cont} X 5 = {cont * 5}");
            Console.WriteLine($"{cont} X 6 = {cont * 6}");
            Console.WriteLine($"{cont} X 7 = {cont * 7}");
            Console.WriteLine($"{cont} X 8 = {cont * 8}");
            Console.WriteLine($"{cont} X 9 = {cont * 9}");
            Console.WriteLine($"{cont} X 10 = {cont * 10}");

        }

        
    }
}
