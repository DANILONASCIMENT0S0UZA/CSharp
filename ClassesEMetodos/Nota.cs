using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Nota {

        class Media {


            private int nota1;
            private int nota2;
            private int nota3;
            private int nota4;


            private int media {

                get {

                    return media;
                }
                set {
                   
                    media = value;
                }
            }
        }
    

        public static void Executar() {


            Console.WriteLine("Qual foi a 1° nota?");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a 2° nota?");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a 3° nota?");
            int nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a 4° nota?");
            int nota4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A média do aluno foi {(nota1 + nota2 + nota3 + nota4)/4}");
        }
    }
}
