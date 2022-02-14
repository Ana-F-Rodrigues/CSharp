using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto 
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    
    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro); // adiciona elemento na lista

            var combo = new List<Produto>
            {
                new Produto("Camisa", 30.0),
                new Produto("Churrasco",50.50),
                new Produto("Poster", 10)

            };

            carrinho.AddRange(combo); // adiciona varios elementos de uma unica vez
            Console.WriteLine(carrinho.Count);// vemos tamanho da lista
            carrinho.RemoveAt(3); //removemos por indice

            foreach(var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);


        }
    }
}
