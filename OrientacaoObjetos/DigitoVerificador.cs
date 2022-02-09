using System;


namespace CursoCSharp.OrientacaoObjetos
{
    class DigitoVerificador
    {

        public static void Executar()
        {


            string numero = "47839";
            double digitoVerificador = 0;
            double multi = 0;
            double soma = 0;

            // string representa uma coleção de CHAR
            // int é um numero inteiro
            // faz alocação de memoria exemplo: int16 aloca 16 bytes 
            // CHAR é representação numerica associda á 1 bit 
            // 1 byte = 8 bits que tem 256 combinaçoes
            

            for (int posicao = 0; posicao < numero.Length; posicao++)
            {
                var valorPosicao = numero[posicao];
                int num_var = Convert.ToInt32(valorPosicao.ToString()); //converter string  para inteiro
                multi = num_var * posicao;
                soma += multi;

            }

            double resto = soma % 11;

            if (resto == 0 || resto == 10)
            {
                digitoVerificador = 0;
            }
            else
            {
                digitoVerificador = resto;
            }


            Console.WriteLine("O digito Verificador é: {0}-{1} ", numero, digitoVerificador);

        }
    }

}