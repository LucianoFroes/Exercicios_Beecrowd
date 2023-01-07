using System;

namespace Beecrowd.Exercícios {
    class Exe1046 {
        public static void Executar() {

            string[] horasJogo = Console.ReadLine().Split();

            int inicioPartida = int.Parse(horasJogo[0]);
            int terminoPartida = int.Parse(horasJogo[1]);
            int resultadoHoras = terminoPartida - inicioPartida;

            if (inicioPartida == terminoPartida) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            } else {

                if (inicioPartida > terminoPartida) {
                    resultadoHoras += 24;
                    Console.WriteLine($"O JOGO DUROU {resultadoHoras} HORA(S)");
                } else {
                    Console.WriteLine($"O JOGO DUROU {resultadoHoras} HORA(S)");
                }
            }
        }
    }
}
