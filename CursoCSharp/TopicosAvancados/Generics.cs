using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T MetodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base (0)
        {

        }
    }

    class Generics
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.MetodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.MetodoGenerico("teste"));
            Console.WriteLine(caixa2.Coisa.GetType());


            var caixa3 = new CaixaInt();
            Console.WriteLine(caixa3.MetodoGenerico(3535));
        }
    }
}
