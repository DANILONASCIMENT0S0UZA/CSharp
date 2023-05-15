using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class IMC {

        public static void Executar() {
            Console.WriteLine("Qual é seu peso?");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é sua altura?");
            double altura = double.Parse(Console.ReadLine());

            double imc = (peso / (altura*altura));

            if (imc < 18.5) {
                Console.WriteLine("Esta abaixou do peso!");
            } else if (imc >= 18.5 && imc <= 24.9) {
                Console.WriteLine("Esta no peso ideal!");
            } else if (imc > 24.9 && imc <= 29.9) {
                Console.WriteLine("Esta acima do peso!");
            } else if (imc > 29.9 && imc <= 34.9) {
                Console.WriteLine("Esta com obesidade grau 1!");
            } else if (imc > 34.9 && imc <= 39.9) {
                Console.WriteLine("Esta com obesidade grau 2!");
            } else{
                Console.WriteLine("Esta com obesidade grau 3!");
            }
        }
        }
}
