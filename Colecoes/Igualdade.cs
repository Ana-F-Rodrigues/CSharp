using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
   class Igualdade
    { public static void Executar()
        {
            var p1 = new Produto("Caneta",1.89);
            var p2 = new Produto("Caneta",1.89);
            var p3 = p2; 

            Console.WriteLine(p1 == p2); // compara referençias de memoria que apontam para locais diferentes
            Console.WriteLine(p3 == p2); // verdadeiro pois apontam para msm endereço de memoria 
           
            
            Console.WriteLine(p1.Equals(p2)); //compara endereço de memoria

        }
    }
}
