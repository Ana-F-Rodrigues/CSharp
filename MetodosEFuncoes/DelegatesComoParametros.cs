using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegatesComoParametros
    {
        public delegate int Operacao (int x, int y);

        public static int Soma (int x, int y)
        {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultato = op(x, y);
            return "Resultado: " + resultato;


        }
        public static void Executar()
        {
            Operacao sub = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(sub, 3,2));

            Console.WriteLine(Calculadora(Soma,3,2));
        }
    }
}
