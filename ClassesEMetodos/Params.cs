using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        //params = parametros variaveis - Agrupa varios valores dentro dela
        // string[] array
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}",pessoa); // percorre todo o array
            }
        }

        public static void Executar()
        {
            Recepcionar("Pedro", "Ana", "Joao");
        }
    }
}
