﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar(){

            Console.WriteLine("Qual foi a 1° nota?");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a 2° nota?");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a 3° nota?");
            int nota3 = int.Parse(Console.ReadLine());

            int media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7) { 
                Console.WriteLine("O aluno esta APROVADO :)");
            } else { 
                Console.WriteLine("O aluno esta REPROVADO :(");
            }
        }
    }
}
