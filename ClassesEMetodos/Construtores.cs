using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Cliente {
        // atributos de cliente
        public string Nome;
        public string Cpf;
        public string Sexo;
        public string Endereco;
        public int Idade;

        public Cliente(string nome, string cpf, string sexo, string endereco, int idade) {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Idade = idade;

        }

        public Cliente() {

        }

    }

    class Construtores {

        public static void Executar() {

            /* new Cliente() é um construtor
            esse construtor é padrão e não recebe
            nenhum parâmetro */
            var cliente1 = new Cliente();
            cliente1.Nome = "Cleber";
            cliente1.Cpf = "1234578911";
            cliente1.Sexo = "M";
            cliente1.Endereco = "Vila Pires";
            cliente1.Idade = 70;

            // OUTRA FORMA DE CHAMAR O CONSTRUTOR

            var cliente2 = new Cliente("Rogério Ceni", "12345678912","M","São Mateus",52) ;

            var cliente3 = new Cliente()
            {
                Nome = "Amanda",
                Cpf = "1234578913",
                Sexo = "F",
                Endereco = "Sei la",
                Idade = 30
            };

            Console.WriteLine($"Olá {cliente1.Nome} você tem {cliente1.Idade} anos");
        }
    }
}
