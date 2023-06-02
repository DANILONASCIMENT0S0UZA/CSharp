using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Animais {

        public class Animal {

            private string animal;
            private string tipo;

            public string Nome {
                get {
                    return animal;
                    
                }
                set {
                    animal = value;
                }
            }

            public string Tipo {
                get {
                    return tipo;

                }
                set {
                    tipo = value;
                }
            }


            public Animal(string nome, string tipo) {
                Nome = nome;
                Tipo = tipo;
            }
        }
        public static void Executar() {

            var animal = new Animal("Cachorro", "Amigavel");

            Console.WriteLine($"{animal.Nome} é {animal.Tipo}");
        }
    }
        }

