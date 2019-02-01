using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area de circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos Internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;

            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;

            Console.WriteLine("Saldo de Gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário" + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor Valor Int" + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Populacao brasileira" + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor Long" + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine(" Populacao Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Está chovendo: " + precoComputador);

            double valorDeMercado = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple: " + valorDeMercado);

            decimal distanciaEntreEstrlas = decimal.MaxValue;
            Console.WriteLine("Distancia Entre Estrelas: " + distanciaEntreEstrlas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine("Texto " + texto);
        }
    }
}
