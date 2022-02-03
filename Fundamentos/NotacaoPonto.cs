using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "ola".ToUpper(); // LETRAS MAIUSCULAS
            var saudacao1 = "ola".ToUpper().Insert(3, "  Word").Replace("Word!", "Mundo");
            Console.WriteLine(saudacao);
            Console.WriteLine(saudacao1);
            Console.WriteLine("Tamanho".Length);


            string valorImportante = null;
          // Console.WriteLine(valorImportante.Length); // valor vazio por isso o erro
           Console.WriteLine(valorImportante?.Length); // forma segura de usar
           
        }
    }
}
