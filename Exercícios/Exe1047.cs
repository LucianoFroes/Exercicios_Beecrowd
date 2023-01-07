using System;


namespace Beecrowd.Exercícios {
     class Exe1047 {
        public static void Executar() {

            string[] horasJogo = Console.ReadLine().Split();

            int inicioPartidaHoras = int.Parse(horasJogo[0]);
            int inicioPartidaMinutos = int.Parse(horasJogo[1]);

            int terminoPartidaHoras = int.Parse(horasJogo[2]);
            int terminoPartidaMinutos = int.Parse(horasJogo[3]);

            int horasMin1 = (inicioPartidaHoras * 60) + inicioPartidaMinutos;
            int horasMin2 = (terminoPartidaHoras * 60) + terminoPartidaMinutos;
            int resultado;
            int horasMinutos = 24 * 60;

            if(horasMin2 > horasMin1) {
                resultado = horasMin2 - horasMin1;
                Console.WriteLine($"O JOGO DUROU {resultado / 60} HORA(S) E {resultado % 60} MINUTO(S)");

            }else if(horasMin1 > horasMin2){
                resultado = (horasMinutos - horasMin1) + horasMin2;
                Console.WriteLine($"O JOGO DUROU {resultado / 60} HORA(S) E {resultado % 60} MINUTO(S)");

            } else {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }

        }
    }
}
