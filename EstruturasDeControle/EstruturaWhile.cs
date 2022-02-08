using System;


namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random(); //Gera numero aleatorio entre 1/15

            int numeroSecreto = random.Next(1, 16); // o numero é armazenado na variavel "numeroSecreto"
            bool numeroEncontrado = false; //inicializa como falso
            int tentativasRestantes = 5; // a pessoa tem 5 tentativas para acertar o numero
            int tentativas = 0; // inicializa em 0

            while (tentativasRestantes > 0 && !numeroEncontrado) // SE o numero de tentativas fo MAIOR QUE 0 e o numero nao foi encontrado
           {
                Console.WriteLine("Insira seu Palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) // se for igual mostra que acertou e colore o console de verde
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;

                } else if (palpite > numeroSecreto) // menor mostra restante de tentativas
                {
                    Console.WriteLine("Menor....Tente Novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }else
                {
                    Console.WriteLine("Maior....Tente Novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }

            }


        }
    }
}
