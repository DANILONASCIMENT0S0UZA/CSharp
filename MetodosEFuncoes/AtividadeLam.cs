using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    class AtividadeLam {

        public static void Executar() {


            Func<int, bool> numeroPar = i => {
                return (i % 2) == 0;
            };

            Console.WriteLine(numeroPar(4));
            
        }
    }
}
