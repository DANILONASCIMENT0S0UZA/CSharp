using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {

            /* instanciando a classe Pessoa
             * e criando um objeto pessoa1*/

            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Cleiton Peres";
            pessoa1.idade = 22;

            pessoa1.ApresentarNoConsole();
        }
    }
}
