using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Nai {

        public class Pessoal {
            private string nome;
            private double altura;
            private int idade;


            public string Nome {
                get {
                    return nome;
                }
                set {
                    nome = value;
                }
            }

            public double Altura {
                get {
                    return altura;
                }
                set {
                    altura = value;
                }
            }

            public int Idade {
                get {
                    return idade;
                }
                set {
                    idade = value;
                }
            }

            public Pessoal(string nome, double altura, int idade) {
                Nome = nome;
                Altura = altura;
                Idade = idade;
            }
        }
        public static void Executar() {

            var pessoa = new Pessoal("Wandebas", 1.75, 1983);

            Console.WriteLine($"Ola {pessoa.Nome}, tenho {pessoa.Altura} de altura e tenho {2023-pessoa.Idade} anos");
        }
    }
}