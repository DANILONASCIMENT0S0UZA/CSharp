using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Média - Fundamentos ",Media.Executar},
                {"Exercicio 2 - Fundamentos ",exercicioDois.Executar},
                {"Exercicio 3 - Fundamentos ",exercicioTres.Executar},
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar },
                {"Operadores Aribuição - Fundamentos",OperadoresAribuicao.Executar },
                {"IF - Fundamentos",EstruturaIf.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}