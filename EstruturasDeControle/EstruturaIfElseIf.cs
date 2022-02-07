using System;


namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do Aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9)
            {
                Console.WriteLine("Quadro de Honra");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Te vejo na proxima....");
            }


            Console.WriteLine("Fim!");


        }
    }
}
