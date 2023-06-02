using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

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

                  //-------------------------------------------------------------------------

                {"IF - Estrutura de Controle",EstruturaIf.Executar },
                {"IF e Else - Estrutura de Controle",IFandELSE.Executar },
                {"Senha - Estrutura de Controle",Senha.Executar },
                {"Escola - Estrutura de Controle",escola.Executar },
                {"IMC - Estrutura de Controle",IMC.Executar },
                {"Estrutura Switch - Estrutura de Controle",EstruturaSwitch.Executar },
                 {"DDD - Estrutura de Controle",DDD.Executar },
                 {"Estrutura While e For - Estrutura de Controle",EstruturaWhileEFor.Executar },
                {"Estrutura de Foreach - Estrutura de Controle",EstruturaForeach.Executar },
                 {"While - Estrutura de Controle", @while.Executar },
                 {"Contador - Estrutura de Controle", contador.Executar },
                 {"Tabuada - Estrutura de Controle", Tabuada.Executar },

                 //-------------------------------------------------------------------------

                 {"Membros - Classes e Métodos", Membros.Executar },
                 {"Jogo - Classes e Métodos", Jogo.Executar },
                 {"Construtores - Classes e Métodos", Construtores.Executar },
                 {"Metodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                 {"Conveter Reais Para Dolar - Classes e Métodos", ConveterRD.Executar },
                 {"Conveter  Celsius para Fahrenheit - Classes e Métodos", ConveterGraus.Executar },
                 {"Metodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar },
                 {"Params - Classes e Métodos", Params.Executar},
                 {"Get e Set - Classes e Métodos", GetSet.Executar},
                 {"Get e Set 2º exemplo - Classes e Métodos", GetSet2.Executar},
                 {"Nota - Classes e Métodos", Nota.Executar},
                 {"Registro - Classes e Métodos", Nai.Executar},
                  {"Animal - Classes e Métodos", Animais.Executar},

                 //-------------------------------------------------------------------------
                 {"Array - Coleções", Arrays.Executar},
                 {"Queue - Coleções", Queue.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}