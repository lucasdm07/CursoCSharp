using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.API
{
    class ExemploDirectoryInfo
    {   
        public static void Executar()
        {
            var dirProjeto = @"~/Documents/GitHub/CursoCSharp/CursoCSharp/".ParseHome();
            var dirInfo = new DirectoryInfo(dirProjeto);

            if(!dirInfo.Exists)
                dirInfo.Create();

            Console.WriteLine("\n\n== Arquivos ========================");
            var arquivos = dirInfo.GetFiles();
            foreach(var arquivo in arquivos)
                Console.WriteLine(arquivos);

            Console.WriteLine("\n\n== Diretórios ======================");
            var pastas = dirInfo.GetDirectories();
            foreach(var pasta in pastas)
                Console.WriteLine(pasta);

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}
