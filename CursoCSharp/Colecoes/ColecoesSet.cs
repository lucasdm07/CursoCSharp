using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Teste List", 99.9),
                new Produto("asdasda", 99.9),
                new Produto("asdasda", 99.9)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            foreach(var item in carrinho)
            {
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
