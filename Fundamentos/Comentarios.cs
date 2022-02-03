using System;


namespace CursoCSharp.Fundamentos

{   /// <summary>
    /// 
    /// </summary>
    class Comentarios
    {
        public static void Executar()
        {
            // Cuidado com os comentarios desnecessarios
            Console.WriteLine("Codigo claro é sempre melhor!");

             /// 3 barras para gerar documentação
            Console.WriteLine("O C# tem o XML Comments");

            /* Padrão
             * 
             */

            Console.WriteLine("Comentario de multiplas linhas");

            Console.WriteLine("CTRL + U = Descomenta bloco de codigo!");

            Console.WriteLine("CTRL + C = Comenta bloco de codigo!");
            Console.WriteLine("Lembrar de subir todas atualizações para o Git ");
        }
    }
}
