using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Arrays {

        public static void Executar() {

            /*
            string[] alunos = new string[5];

            alunos[0] = "Vanderley";
            alunos[1] = "Maria Joquina";
            alunos[2] = "Cleyton";
            alunos[3] = "Fernando";
            alunos[4] = "Bibi";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            */

            double somatorio = 0;
            double[] notas = { 7.5, 8.5, 6.5 };

            foreach (var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media.ToString("#.##"));
            }
        }
    }

