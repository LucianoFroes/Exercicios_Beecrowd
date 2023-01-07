using System;

namespace Beecrowd.Exercícios {
    class Exe1097 {
        public static void Executar() {

            int valorJ = 0;

            for (int i = 1; i <= 9; i += 2) {
                for (int j = (7 + valorJ); j <= (7 + valorJ) && j >= (5 + valorJ); j--) {
                    Console.WriteLine($"I={i} J={j}");
                }
                valorJ+= 2;
            }
        }
    }
}
