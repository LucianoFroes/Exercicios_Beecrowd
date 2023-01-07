using System;

namespace Beecrowd.Exercícios {
     class Exe1095 {

        public static void Executar() {

            int j = 60;

            for(int i = 1; j >= 0; i+= 3) {
                Console.WriteLine($"I={i} J={j}");
                j -= 5;    
            }
        }
    }
}
