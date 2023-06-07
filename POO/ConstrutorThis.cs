using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO {
    class ConstrutorThis {
        
        public class Animal {

            public string Nome;

            public Animal(string nome) {

                Nome = nome;
            }
                 
        }
        public class Cachorro : Animal {
            public double Altura { get; set; }

            public Cachorro(string nome) : base(nome) {
                Console.WriteLine($"Cachorro {nome} foi iniciado");
            }
            /*aqui estou usando o this para chamar o construtor (nome)
             * da propria classe que é do Cachorro, pórem esse nome foi
             * pegado da herança de animal
             */
            public Cachorro(string nome, double altura) : this(nome) {
                Altura = altura;
            }

            public override string ToString() {
                return $"{Nome} tem {Altura} cm de altura";
            }
        }

        public static void Executar() {

            var cleiton = new Cachorro("Cleiton",0);
            var maxwell = new Cachorro("Maxwell",40.0);
        }
    }
}
