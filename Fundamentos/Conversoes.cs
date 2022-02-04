using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; //conversao implicita

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; //cache converte um tipo em outro explicita
            Console.WriteLine("Nota truncada: {0}", notaTruncada); //temos perca de informação

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade Inserida: {0}", idadeInteiro);


            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro numero: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); // tentar converta palavra e jogue dentro do numero
            Console.WriteLine("Resultado1: {0}", numero1);


            Console.Write("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int  numero2); 
            Console.WriteLine("Resultado2: {0}", numero2);


        }
    }
}
