using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Jogo {

        public static void Executar() {

            game jogos = new game();


            jogos.Nome = "Gris";


            jogos.ApresentarNoConsole();
        }

    }
}
