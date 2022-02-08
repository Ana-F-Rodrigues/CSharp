using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraComum
    {
        //Todo metodo DEVE TER ASSINATURA UNICA(NOME E PARAMETROS)
        // Não criei construtor o que significada que implicitamente ela ja tem um construtor padrao
        public int Somar(int a, int b) // metodo retorna um inteiro
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum(); // criando instancia de Calculadora
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2,7));
            Console.WriteLine(calculadoraComum.Multiplicar(2,2));
        }
    }
}
