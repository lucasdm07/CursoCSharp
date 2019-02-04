using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }
    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro("BMW", "325i",2017);
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");
        }
    }
}
