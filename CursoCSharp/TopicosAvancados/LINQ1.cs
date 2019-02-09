using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1
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
            Console.WriteLine("== APROVADOS =========================");
            var aprovados = alunos.Where(a => a.Idade > 24).OrderBy(a => a.Nome);
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }
            Console.WriteLine("\n== CHAMADA ==========================");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("\n== APROVADOS (por Idade) ==========");
            var alunosAprovados = 
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach(var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
