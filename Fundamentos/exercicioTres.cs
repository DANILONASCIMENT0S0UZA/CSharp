using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class exercicioTres {

            public static void Executar() {

                Console.WriteLine("Digite o numero de funcionario!");
                int f1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite quantas horas que o funcionario vai trabalhar!");
                int h1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual é o valor de cada hora!");
            double v1 = double.Parse(Console.ReadLine());


            double salario = h1 * v1;


                Console.WriteLine($"Numeros de funcionarios: {f1}");

                Console.WriteLine($"Quantas salario: R${salario.ToString("#,##")}");
            }
        }
    }


