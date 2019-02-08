﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 3);
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // data sem hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);
            // data com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine(diaAtual.Minute);
            Console.WriteLine(diaAtual.Second);
            Console.WriteLine(diaAtual.Hour);

            Console.WriteLine(diaAtual.AddDays(1));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
