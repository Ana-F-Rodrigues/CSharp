using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar ()
        {
            var dirProjeto = @"C:\Users\Ana\Desktop\FULLSTACK\FullStack";

            var dirInfo = new DirectoryInfo(dirProjeto);

            if(!dirInfo.Exists)
            {
                dirInfo.Create();
            }


            Console.WriteLine("*** Arquivos ****");
                var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n****** Diretorios *****");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}
