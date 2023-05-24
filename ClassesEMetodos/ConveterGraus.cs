using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ConveterGraus {

        class ConverterG {

            public double Grau(double celsius) {

                return (celsius * 9 / 5) + 32;

            }

        }

        public static void Executar() {

            

            var CF = new ConverterG();

            Console.WriteLine("Digite o valor em celsius!");
            double celsius  = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em fahrenheit!");
            Console.WriteLine(CF.Grau(celsius).ToString("#,##"));
        }
    }
}
