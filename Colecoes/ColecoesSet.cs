using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
  
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro); // adiciona elemento na lista

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 30.0),
                new Produto("Churrasco",50.50),
                new Produto("Poster", 10)

            };

            carrinho.UnionWith(combo); // altera carrinho adicionando tudo sem duplicação
            Console.WriteLine(carrinho.Count);// vemos tamanho da lista
           // carrinho.RemoveAt(3); 

            foreach(var item in carrinho)
            {
               // Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            


        }
    }
}
