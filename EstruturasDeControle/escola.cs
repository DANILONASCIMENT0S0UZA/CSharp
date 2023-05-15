using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class escola {
        public static void Executar() {
            Console.WriteLine("Qual foi a 1° nota?");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a 2° nota?");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a 3° nota?");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7) {
                Console.WriteLine("O aluno esta APROVADO :)");
            } else if (media >= 5 && media < 7) {
                Console.WriteLine("O aluno esta de RECUPERAÇÃO :|");
            }else{
                Console.WriteLine("O aluno esta REPROVADO :(");
            }
        }
    }
}
