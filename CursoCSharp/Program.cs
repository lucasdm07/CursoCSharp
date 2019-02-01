using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                { "Comentarios - Fundamentos", Comentarios.Executar},
                { "Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                { "Inferencia - Fundamentos", Inferencia.Executar},
                { "Interpolacao - Fundamentos", Interpolacao.Executar},
                { "NotacaoPonto - Fundamentos", NotacaoPonto.Executar},
                { "LendoDados - Fundamentos", LendoDados.Executar},
                { "Formatando Números - Fundamentos", FormatandoNumero.Executar},
                { "Conversões - Fundamentos", Conversoes.Executar},
                { "Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                { "Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                { "Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                { "Operadores Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                { "Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                { "Operadores Ternarios - Fundamentos", OperadoresTernarios.Executar},
            });

            central.SelecionarEExecutar();
            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
    }
}