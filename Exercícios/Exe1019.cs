using System;

namespace Beecrowd.Exercícios {
     class Exe1019 {
        public static void Executar() {

            int tempoSegundos = int.Parse(Console.ReadLine());
            int segundos;
            int tempoMinutos;
            int minutos;
            int horas;

            tempoMinutos = tempoSegundos / 60;
            horas = tempoMinutos / 60;
            segundos = tempoSegundos % 60;
            minutos = tempoMinutos % 60;


            Console.WriteLine($"{horas}:{minutos}:{segundos}");

        }
    }
}
