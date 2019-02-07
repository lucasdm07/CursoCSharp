using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    // Clase sem herança
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    //sealed class SouFilho : SemFilho
    //{

    //}
    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    // Realiza a sobescrita e sela ela para nao ter mais herança
    class Pai : Avo
    {
        public override sealed bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {

    }
    
    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
