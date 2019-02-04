using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
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
                // Estruturas de controle
                { "Estrutura IF - Controle", EstruturaIf.Executar},
                { "Estrutura ForEach - Controle", EstruturaForEach.Executar},
                // Classes e Metodos
                { "Membros - Classes e metodos", Membros.Executar},
                { "Construtores - Classes e metodos", Construtores.Executar},
                { "Métodos Com Retorno - Classes e metodos", MetodosComRetorno.Executar},
                { "Métodos Estáticos - Classes e metodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e metodos", AtributosEstaticos.Executar},
                { "Desafio Atributo - Classes e metodos", DesafioAtributo.Executar},
                { "Params - Classes e metodos", Params.Executar},
                { "Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                { "Get Set - Classes e Métodos", GetSet.Executar},
                { "Props - Classes e Métodos", Props.Executar},
            });

            central.SelecionarEExecutar();
            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
    }
}