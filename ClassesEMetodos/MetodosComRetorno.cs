using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class MetodosComRetorno {

        class CalculadoraComum {

            public int Somar(int a, int b) {
                return a + b;
            }
            public int Subtração(int a, int b) {
                return a - b;
            }

            public int Multiplicação(int a, int b) {
                return a * b;
            }

            public int Divisão(int a, int b) {
                return a / b;
            }
            
        }

        public static void Executar() {

            var calculadoraComum = new CalculadoraComum();

            var resultado = calculadoraComum.Somar(27, 54);
            Console.WriteLine(resultado);

            Console.WriteLine(calculadoraComum.Subtração(27, 54));
        }
    }
}
