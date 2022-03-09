using System;
using System.IO;

namespace CursoCSharp.Api
{
     class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpeDestino".ParseHome();
            var dirProjeto = @"C:\Users\Ana\Desktop\FULLSTACK\FullStack";

            if(Directory.Exists(novoDir)) 
            {
                Directory.Delete(novoDir, true);
            }

            if(Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("**** Pasta Listadas **********");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n***** Arquivos ******");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n**** Pasta Raiz *****");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
