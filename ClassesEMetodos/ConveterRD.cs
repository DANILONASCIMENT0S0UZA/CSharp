using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ConveterRD {

        class ConverterDolar {

            public double RD(double reais,double dolar) {

                return reais *  dolar;
           
            }
            
        }

        public static void Executar() {

            double dolar = 4.95;

            var RDS = new ConverterDolar();

            Console.WriteLine("Digite o valor!");
            double reais = double.Parse(Console.ReadLine());

            Console.WriteLine(RDS.RD(reais,dolar).ToString("#,##"));
        }
    }
}
