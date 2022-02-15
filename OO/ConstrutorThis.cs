using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString() // converte um objeto em uma string
        {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            var toto = new Cachorro("Toto");
            var gaia = new Cachorro("Gaia",40.0);

            Console.WriteLine(toto);
            Console.WriteLine(gaia);
        }
           
    }
}
