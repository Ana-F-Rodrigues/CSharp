using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;

    }
    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() { Nome ="Pedro", Idade = 24, Nota = 8.0},
                new Aluno() { Nome ="Andre", Idade = 21, Nota = 4.3},
                new Aluno() { Nome ="Ana", Idade = 25, Nota = 9.5},
                new Aluno() { Nome ="Jorge", Idade = 20, Nota = 8.5},
                new Aluno() { Nome ="Ana", Idade = 20, Nota = 7.7},
                new Aluno() { Nome ="Julia", Idade = 22, Nota = 7.5},
                new Aluno() { Nome ="Marcio", Idade = 18, Nota = 6.8}

            };
            Console.WriteLine("********* APROVADOS ******* ");
            var aprovados = alunos.Where(a => a.Idade > 24);
            foreach(var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }
                

        }
    }
}
