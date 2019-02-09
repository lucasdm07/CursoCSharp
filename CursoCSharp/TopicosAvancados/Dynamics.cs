using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;
            meuObjeto++;

            Console.WriteLine(meuObjeto);
            dynamic aluno = new System.Dynamic.ExpandoObject();
        }
    }
}
