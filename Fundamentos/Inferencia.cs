using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Ana"; //C# entende o tipo atribuido e substitui por string/int
            Console.WriteLine(nome);

            var numero = 50;
            Console.WriteLine(numero); // veja que entendeu que atribui um inteiro
           
        }
    }
}
