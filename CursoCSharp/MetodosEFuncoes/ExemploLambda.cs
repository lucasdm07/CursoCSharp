using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            // (): sem parametros
            // Todo action nao tem retorno
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            // recebe int de entrada e retorna uma string
            Func<int, string> conversorHex = numero => numero.ToString("X");
            //Func<int, string> conversorHex = (numero) => 
            //{ 
            //  numero.ToString("X"); 
            //};
            Console.WriteLine(conversorHex(1234));

            // 3 int`s de entrada e uma string de retorno
            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(10,12,2019));
        }
    }
}
