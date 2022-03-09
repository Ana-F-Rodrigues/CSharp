using System;



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

    public class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this; //retorna a propia instancia
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }


    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum(); // criando instancia de Calculadora
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(2, 2));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
