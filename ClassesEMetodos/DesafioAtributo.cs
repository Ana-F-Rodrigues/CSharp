using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
   class DesafioAtributo
    {
       int a = 10;
        public static void Executar ()
        {
            // acesse a variavel A dentro deste metodo

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);

            //Foi necessario criar uma instancia da propia classe
            // para conseguir acessar a variavel A
            // Atributo pertence a instancia por isso 
            //nao conseguimos acessa-la
           
        }
    }
}
