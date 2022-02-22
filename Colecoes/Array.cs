using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
     class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Ana";
            alunos[1] = "Joao";
            alunos[2] = "Cleber";
            alunos[3] = "Flavio";
            alunos[4] = "Jose";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(var nota in notas)
            {
                somatorio += nota;

            }


            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'a', 'b', 'c', 'd' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);


        }
    }
}
