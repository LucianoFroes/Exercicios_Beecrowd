using System;

namespace Beecrowd.Exercícios {
     class Exe1044 {
        public static void Executar() {

            string[] numMultiplos = Console.ReadLine().Split();

            int num1 = int.Parse(numMultiplos[0]);  
            int num2 = int.Parse(numMultiplos[1]);  

            if(num2 % num1 == 0 || num1 % num2 == 0) {
                Console.WriteLine("Sao Multiplos");

            } else {
                Console.WriteLine("Nao sao Multiplos");

            }

        }
    }
}
