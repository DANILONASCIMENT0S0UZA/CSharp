﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO {
    class Polimorfismo {

        public class Comida {
            //criando atributo de comida
            public double Peso;


            //criando construtor personalizado de comida
            public Comida(double peso) {
                Peso = peso;
            }
            public Comida() { }
        }

        public class Feijao : Comida {
            public double Peso;
        }

        public class Arroz : Comida {
            public double Peso;
        }

        public class Carne : Comida {
            public double Peso;
        }

        //criando 3 métodos

        public class Pessoa {
            public double Peso;

            // usando polimorfismo

            public void Comer(Comida comida) {
                Peso += comida.Peso;
            }

            /*
            //criando 3 métodos
            public void Comer(Feijao feijao) {
                Peso += feijao.Peso;
            }

            public void Comer(Arroz arroz) {
                Peso += arroz.Peso;
            }

            public void Comer(Carne carne) {
                Peso += carne.Peso;
            }
            */
        }

        public static void Executar() {

            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;

            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"O peso do cliente agora é {cliente.Peso}");
        }
    }
}
