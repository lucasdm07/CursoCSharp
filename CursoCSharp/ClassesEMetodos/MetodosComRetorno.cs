using System;
namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(double a, int b)
        {
            return (int)a + b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }

    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(1, 2);

            var caculadoraCadeia = new CalculadoraCadeia();
            caculadoraCadeia.Somar(3).Multiplicar(2);

            resultado = caculadoraCadeia.Somar(4).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
