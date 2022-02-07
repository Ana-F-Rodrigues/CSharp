using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota invalida? {0}", nota > 10.0); //MAIOR QUE
            Console.WriteLine("Nota invalida? {0}", nota < 0); // MENOR QUE
            Console.WriteLine("Perfeito? {0}", nota == 10.0); //COMPARAÇÃO
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); //DIFERENTE 
            Console.WriteLine("Passou por media? {0}", nota >= notaDeCorte); //MAIOR IGUAL
            Console.WriteLine("Recuperação {0}", nota < notaDeCorte); 
            Console.WriteLine("Reprovado {0}", nota <= 3.0);
        }
    }
}
