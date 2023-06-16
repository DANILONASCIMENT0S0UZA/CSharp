using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO {
    class Sealed {

        /*classes do tipo sealed não permite herança*/
        sealed class Semfilho {

            public double ValorDaHerança() {
                return 1.407033;
            }
        }

        /*class Soufilho : SemFilho{
         
         }*/

        class Avo {
            /*métodos virtuais podem ser sobrescritos*/

            public virtual bool HorarNomeFamilia() {
                return true;
            }
        }

        class Pai : Avo {
            public override bool HorarNomeFamilia() {
                return true;
            }
        }

        class FilhoRebelde: Pai {
            public override bool HorarNomeFamilia() {
                return false;
            }
        }

        public static void Executar() {

            Semfilho semfilho = new Semfilho();
            Console.WriteLine(semfilho.ValorDaHerança());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HorarNomeFamilia());
        }
    }
}

