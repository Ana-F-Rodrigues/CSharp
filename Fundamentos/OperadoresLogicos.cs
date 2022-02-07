using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
   class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = true;

            bool comprouTV50 = executouTrabalho1 && executouTrabalho2; // E
            Console.WriteLine("Comprou a TV 50? {0}", comprouTV50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // OU
            Console.WriteLine("Comprou o sorvete ? {0}", comprouSorvete);

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2; // OU EXCLUSIVO
            Console.WriteLine("Comprou a TV 32? {0} ", comprouTV32);

            Console.WriteLine("Mais saudavel? {0} ", !comprouSorvete); // NEGAÇÃO



        }
    }
}
