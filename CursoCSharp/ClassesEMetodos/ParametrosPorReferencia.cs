using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }
        public static void AlterarOut(out int numero)
        {
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar()
        {
            // uso do ref é a mesma logica de passar um ponteiro
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);
            // o uso do out é uma melhor pratica pois evita confusao e possiveis bugs
            // porem ele nao reaproveita o conteudo anterior, sempre o valor sera ignorado.
            AlterarOut(out int b);
            Console.WriteLine(b);
        }
    }
}
