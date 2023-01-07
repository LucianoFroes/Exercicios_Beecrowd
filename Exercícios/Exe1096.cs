using System;


namespace Beecrowd.Exercícios {
    class Exe1096 {
        public static void Executar() {

            for (int i = 1; i <= 9; i += 2) {
                for (int j = 7; j <= 7 && j >= 5; j--) {
                    Console.WriteLine($"I={i} J={j}");
                }
            }
        }
    }
}
