using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
   class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // apenas 1 casa decimal
            Console.WriteLine(valor.ToString("C")); // valor monetario
            Console.WriteLine(valor.ToString("P")); // PORCENTUAL
            Console.WriteLine(valor.ToString("#.##")); // formato valido

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //quantidade de caracteres

        }

    }
}
