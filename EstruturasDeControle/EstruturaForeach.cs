using System;


namespace CursoCSharp.EstruturasDeControle
{
     class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "Opa";

            foreach(var letra in palavra) // percore letra por letra da palavra
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };
            foreach(string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
