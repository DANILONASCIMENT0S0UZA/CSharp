using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class Senha {
        public static void Executar() {

            Console.WriteLine("Criar a sua senha!");
            var senha = Console.ReadLine();

            Console.WriteLine("Digite a senha para logar!");
            var senha_R = Console.ReadLine();

            if (senha == senha_R) {
                Console.WriteLine("ACESSO PERMITIDO!");
            } else {
                Console.WriteLine("NEGADO PERMITIDO!");
            }
        }
        }
    }

