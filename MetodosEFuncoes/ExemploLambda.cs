using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
     class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());
        }
    }
}
