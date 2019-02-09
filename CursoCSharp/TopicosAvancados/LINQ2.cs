using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            List<Aluno> alunos = new List<Aluno>
            {
                new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() { Nome = "Betao", Idade = 25, Nota = 9.0 },
                new Aluno() { Nome = "Lucas", Idade = 27, Nota = 10.0 },
                new Aluno() { Nome = "Ana", Idade = 27, Nota = 10.0 },
                new Aluno() { Nome = "Ana", Idade = 21, Nota = 7.5 },
                new Aluno() { Nome = "Julia", Idade = 18, Nota = 6.8 },
            };


            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            if(fulano == null)
            {
                Console.WriteLine("Aluno inexistente!");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));
            if(sicrano == null)
            {
                Console.WriteLine("Sicrano inexistente!");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nota.Equals("Ana"));
            if (sicrano == null)
                Console.WriteLine("Outra ana inexistente!");
            else
                Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip)
                Console.WriteLine(item.Nome);

            var menorNota = alunos.Min(aluno => aluno.Nota); 
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaNotas = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNotas);
        }
    }
}
