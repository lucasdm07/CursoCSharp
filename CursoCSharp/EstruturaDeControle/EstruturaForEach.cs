using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavras = "Opa!";

            foreach (var letra in palavras)
            {
                Console.WriteLine(letra);
            }

            var alunos = new String[] { "Ana", "Bia", "Carlos" };

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
