using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o sei nome ? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é sua idade ? ");
            int idade = int.Parse(Console.ReadLine()); // converte

            Console.Write("Qual é o seu salario ?");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture); 

            Console.WriteLine($"{nome} {idade} R${salario}");

               
        }
    }
}
