using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular // nao posso instanciar
    {
        public abstract string Assistente();  //pode ter metodos abstratos e concretos

        public string Tocar()
        {
            return "Trim trim....";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby! ";
        }
    }

    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri";
        }
    }



    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new IPhone(),
                new Samsung()
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }

        // Conceito de classe inacabada serve para ser HERDADA por classe CONCRETAS

    }
}
