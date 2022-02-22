using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
     class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3); // adiciona itens na fila
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); // remove elemento do topo

            foreach(var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); // primeiro a entrar é ultimo a sair
            Console.WriteLine(pilha.Count);
        }
    }
}
