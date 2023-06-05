using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Queue {
        public static void Executar() {

            var fila = new Queue<string>();

            fila.Enqueue("Milo");
            fila.Enqueue("Wanderely");
            fila.Enqueue("Cleyton");
            fila.Enqueue("Agatha");
            fila.Enqueue("Triz");

            //Pegando o primeiro da fila

            Console.WriteLine(fila.Peek());

            //contando a fila

            Console.WriteLine(fila.Count);

            //remover a primeira pessa da fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            //verificando quantos pessoas na fila
            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }
        }
    }
}
