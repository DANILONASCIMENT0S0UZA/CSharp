using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class game {

        public string Nome;

        public string Apresentar() {
            return string.Format($"{Nome} melhor jogo que existe! ");

        }

        public void ApresentarNoConsole() {


            Console.WriteLine(Apresentar());
        }
    }
}
