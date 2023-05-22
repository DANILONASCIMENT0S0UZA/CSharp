﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaForeach {
        public static void Executar() {
            var palavra = "banana";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            // percorrendo um array
            var alunos = new string[] { "José", "Cleyton", "Wandebas", "Cellbit" };
            foreach (var nome in alunos) {
                Console.WriteLine(nome);
            }
        }
    }
}
