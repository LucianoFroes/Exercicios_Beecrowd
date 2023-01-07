using System;

namespace Beecrowd.Exercícios {
     class Exe1037 {
        public static void Executar() {

            double numAleatorio = double.Parse(Console.ReadLine());

            if(numAleatorio >= 0 && numAleatorio <= 25) {
                Console.WriteLine("Intervalo [0,25]");

            }else if(numAleatorio > 25 && numAleatorio <= 50) {
                Console.WriteLine("Intervalo (25,50]");

            }else if(numAleatorio > 50 && numAleatorio <= 75) {
                Console.WriteLine("Intervalo (50,75]");

            }else if(numAleatorio > 75 && numAleatorio <= 100) {
                Console.WriteLine("Intervalo (75,100]");

            }else{
                Console.WriteLine("Fora de intervalo");
            }

        }

    }
}
