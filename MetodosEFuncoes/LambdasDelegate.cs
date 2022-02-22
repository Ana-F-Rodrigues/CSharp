using System;


namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y); // criar tipos com assinatura da função
     class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao subr = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(subr(5,2));
            Console.WriteLine(mult(5,2));
        }
    }
}
