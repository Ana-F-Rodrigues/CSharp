using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2022, month: 2,  day: 17);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutos: " + diaAtual.Minute);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D")); //DESCRITIVO
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G")); // hora minutos e segundos
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
