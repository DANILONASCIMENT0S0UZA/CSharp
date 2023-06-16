using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes {
    class PrimeiraExcecao {

        public class Conta {
            private double Saldo;

            public Conta(double saldo) {
                Saldo = saldo;
            }
            public void Sacar(double valor) {
                if (valor > Saldo) {
                    throw new ArgumentException("Saldo Insuficiente");
                }
                Saldo -= valor;
            }
        }

        public static void Executar() {

            var conta = new Conta(1200);

            try {
                conta.Sacar(500);
                Console.WriteLine("Valor retirado com sucesso!");
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("obrigado");
            }
        }
    }
}
