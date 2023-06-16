using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO {
    class Atividade {

        public class Cliente {
            //criando atributo de comida
            public string Nome;
            public string Tipo;


            //criando construtor personalizado de comida
            public Cliente(string nome, string tipo) {
                Nome = nome;
                Tipo = tipo;
            }
            public Cliente() { }

        }

        public class físico : Cliente {
            public string Cpf;
            public string Nome;
            public string Tipo;

        }

        public class jurídico : Cliente {
            public string Cnpj;
            public string Nome;
            public string Tipo;
        }

        public static void Executar() {

            físico pessoa1 = new físico();
            jurídico pessoa2 = new jurídico();


            /*pessoa1.Cpf = "";
            pessoa1.Nome = "";
            pessoa1.Tipo = "";


       
            pessoa2.Cnpj = "";
            pessoa2.Nome = "";
            pessoa2.Tipo = ""; */


            Console.WriteLine("Qual seu nome?");
            pessoa1.Nome = Console.ReadLine();
            pessoa2.Nome = Console.ReadLine();
            

            Console.WriteLine("Digite seu cpf (ser for cliente jurídico aperta Enter)");
            pessoa1.Cpf = Console.ReadLine();

            Console.WriteLine("Digite seu Cnpj");
            pessoa2.Cnpj = Console.ReadLine();


            if (pessoa1.Cpf != "") {
                Console.WriteLine($"Sr ou Sra {pessoa1.Nome},  você é cliente físico");
            } else {
                Console.WriteLine($"Sr ou Sra {pessoa2.Nome}, você é cliente jurídico");
            }

        }
    }
}
