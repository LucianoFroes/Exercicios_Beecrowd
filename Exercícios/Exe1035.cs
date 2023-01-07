using System;


namespace Beecrowd.Exercícios {
     class Exe1035 {
        public static void Executar() {

            string[] vetorNum = Console.ReadLine().Split();

            int valorA = int.Parse(vetorNum[0]);
            int valorB = int.Parse(vetorNum[1]);
            int valorC = int.Parse(vetorNum[2]);
            int valorD = int.Parse(vetorNum[3]);

            int somaCD = valorC + valorD;
            int somaAB = valorA+ valorB;

            if(valorB > valorC && valorD > valorA && somaCD > somaAB && valorC >= 0 && valorD >= 0 && valorA % 2 == 0) {
                Console.WriteLine("Valores aceitos");
                
            } else {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
