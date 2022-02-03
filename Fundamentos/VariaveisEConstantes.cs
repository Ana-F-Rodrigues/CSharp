using System;


namespace CursoCSharp.Fundamentos
{
  class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.15;
            // nao podemos atribuir outro valo a uma constante PI = 5.1;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Area é  " + area);

            //Tipos internos

            bool estaChovendo = true; // verdadeiro ou falso
            Console.WriteLine("Esta chovendo " + estaChovendo);


            byte idade = 45; // 8 bits = 1 byte
            Console.WriteLine("Idade " + idade);


            sbyte saldoDeGols = sbyte.MinValue; // tem sinal entre + e -
            Console.WriteLine("Saldo de Gols " + saldoDeGols);


            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor do  inteiro " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População BR " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorLong);


            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " +populacaoMundial);

            float precoComputador = 1299.99f; //double muito maior que o float por isso usar 'f'
            Console.WriteLine("Preço do PC " + precoComputador);

            double valorDeMercadoDaApple = 1000000000000000000000.00; // Mais usado dos reais
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaDasEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia das Estrelas " + distanciaDasEstrelas);

            char letra = 'b';
            Console.WriteLine("Mostrar letra " + letra);

            string texto = "Olá estamos usando string";
            Console.WriteLine("Usando string " + texto);


        }
    }
}
