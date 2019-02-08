using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;

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
                { "Read Only - Classes e Métodos", ReadOnly.Executar},
                { "Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                { "Enum - Classes e Métodos", ExemploStruct.Executar},
                { "Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                { "Parametros por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},
                { "Parametros padrao - Classes e Métodos", ParametrosPadrao.Executar},
                // Coleções
                { "Array - Colecoes", Colecoes.Array.Executar},
                { "Colecoes List - Colecoes", ColecoesList.Executar},
                { "Colecoes Array List - Colecoes", ColecoesArrayList.Executar},
                { "List Set - Colecoes", ColecoesSet.Executar},
                { "List Queue - Colecoes", ColecoesQueue.Executar},
                { "Igualdade - Colecoes", Igualdade.Executar},
                { "Colecoes Stack - Colecoes", ColecoesStack.Executar},
                { "Dictionary MAPA - Colecoes", ColecoesDictionary.Executar},
                // Orientação a Objetos
                { "Heranca - OO", Heranca.Executar},
                { "Construtor This - OO", ConstrutorThis.Executar},
                { "Encapsulamento - OO", OO.Encapsulamento.Executar},
                { "Polimorfismo - OO", Polimorfismo.Executar},
                { "Interface - OO", Interface.Executar},
                { "Sealed - OO", Sealed.Executar},
                // Metodos e Funcoes
                { "Exemplo Lambda - Metodos e Funcoes", ExemploLambda.Executar},
                { "Lambdas Delegate - Metodos e Funcoes", LambdasDelegate.Executar},
                { "Delegate com Funcoes Anonimas - Metodos e Funcoes", DelegateFunAnonima.Executar},
                { "Delegate como Parametros - Metodos e Funcoes", DelegatesComoParametros.Executar},
                { "Metodos de Extensao - Metodos e Funcoes", MetodosDeExtensao.Executar},
                // Metodos e Funcoes
                { "Primeira Excecao - Metodos e Funcoes", PrimeiraExcecao.Executar},
                { "Excecoes Personalizadas - Metodos e Funcoes", ExcecoesPersonalizadas.Executar},
                // API
                { "Primeiro Arquivo - API", PrimeiroArquivo.Executar},
                { "Lendo Arquivos - API", LendoArquivos.Executar},
                { "Exemplo FileInfo - API", ExemploFileInfo.Executar},
                { "Diretorios - API", Diretorios.Executar},
                { "Exemplo Directory Info - API", ExemploDirectoryInfo.Executar},
                { "Exemplo Path - API", ExemploPath.Executar},

            });

            central.SelecionarEExecutar();
            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
    }
}