using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class IFandELSE {

        public static void Executar() {

            int ano = 2023;

            Console.WriteLine("Qual ano você nasceu?");
            int nascimento = int.Parse(Console.ReadLine());

            int idade = ano - nascimento;

            if (idade >= 18 && idade <= 70) {
                Console.WriteLine($"Você tem {idade} anos, é obrigatorio votar!");
            }else {
                Console.WriteLine($"Você tem {idade} anos, não é obrigatorio votar!");
            }

        }

    }
}
