using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    interface IOperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    class Soma : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    class Subtracao : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<IOperacaoBinaria> operacoes = new List<IOperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach(var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a,b)}\n";
            }

            return resultado;
        }
    }

    class Interface
    {
        public static void Executar()
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.ExecutarOperacoes(1, 4)); 
        }
    }
}
