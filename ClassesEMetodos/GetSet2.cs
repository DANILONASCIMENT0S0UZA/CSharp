using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class GetSet2 {
        public class CarrOpcinal {

            private double desconto = 0.1;
            private string nome;

            private string Nome {
                get {
                    return "Opcional" + nome;
                }
                set {
                    nome = value;
                }
            }

            //propriedade autoimplementada

            public double Desconto { get; set; }

            public double Preco { get; set; }

            public double PrecoComDesconto {
                get {
                    return Preco - (desconto * Preco);
                }
            }

                public CarrOpcinal(string nome,double preco) {
                Nome = nome;
                Preco = preco;
            }
        }

            public static void Executar() {

                var op = new CarrOpcinal("Aerofólio", 1.500);
                var op2 = new CarrOpcinal("Ar Condicionado", 3.500);
                Console.WriteLine(op.PrecoComDesconto);
                Console.WriteLine(op2.PrecoComDesconto);
        }
        }
    }

