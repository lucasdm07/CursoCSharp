using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        protected double Peso { get; set; }

        public Comida()
        {
        }

        public Comida(double peso)
        {
            Peso = peso;
        }

        public double ValorPeso()
        {
            return Peso;
        }
    }

    public class Feijao : Comida
    {
        public Feijao(double peso) : base(peso)
        {
        }
    }

    public class Arroz : Comida
    {
        public Arroz(double peso) : base(peso)
        {
        }
    }

    public class Carne : Comida
    {
        public Carne(double peso) : base(peso)
        {
        }
    }

    public class Pessoa
    {
        public double Peso;

        public void Comer(Comida comida)
        {
            Peso += comida.ValorPeso();
        }
    }

    class Polimorfismo
    {
        public static void Executar()
        {
            Comida ingrediente1 = new Feijao(0.3);

            Comida ingrediente2 = new Arroz(0.25);

            Comida ingrediente3 = new Carne(0.9);

            Pessoa cliente = new Pessoa
            {
                Peso = 80.2
            };
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"O peso do cliente é {cliente.Peso}");
        }
    }
}
