using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho Nao Reconhecido");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
            
        }
    }
    public class AmigoDistante
    {
        public readonly SubCelebridade amigo = new SubCelebridade();
        public void MeusAcessos()
        {
            Console.WriteLine("Amigo Distante");
            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDoOlho);
            //Console.WriteLine(amigo.NumeroCelular);
            //Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoFamilia);
            //Console.WriteLine(amigo.UsaMuitoPhotoshop);
        }
    }


    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
