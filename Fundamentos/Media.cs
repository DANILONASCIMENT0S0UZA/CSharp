using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Media {

       
        public static void Executar() {

            Console.WriteLine("Qual foi a 1° nota?");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a 2° nota?");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a 3° nota?");
            int nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a 4° nota?");
            int nota4 = int.Parse(Console.ReadLine());

            int media = (nota1 + nota2 + nota3 + nota4)/4;

            Console.WriteLine($"A média do aluno foi {media}");
        }
    }
}
