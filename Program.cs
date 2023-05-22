using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.EstruturaRepeticao;

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
                {"IF - Estrutura de Controle",EstruturaIf.Executar },
                {"IF e Else - Estrutura de Controle",IFandELSE.Executar },
                {"Senha - Estrutura de Controle",Senha.Executar },
                {"Escola - Estrutura de Controle",escola.Executar },
                {"IMC - Estrutura de Controle",IMC.Executar },
                {"Estrutura Switch - Estrutura de Controle",EstruturaSwitch.Executar },
                 {"DDD - Estrutura de Controle",DDD.Executar },
                 {"Estrutura While e For - Estrutura de Controle",EstruturaWhileEFor.Executar },
                 {"While - Estrutura de Repetição", @while.Executar },
                 {"Contador - Estrutura de Repetição", contador.Executar },
                 {"Tabuada - Estrutura de Repetição", Tabuada.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}