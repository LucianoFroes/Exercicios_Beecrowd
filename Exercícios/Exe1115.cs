using System;

namespace Beecrowd.Exercícios {
    class Exe1115 {
        public static void Executar() {

            while (true) {

                string[] cordenadas = Console.ReadLine().Split();

                int x = int.Parse(cordenadas[0]);
                int y = int.Parse(cordenadas[1]);

                if (x == 0 || y == 0) {
                    break;

                } else if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");

                } else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");

                } else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");

                } else if (x > 0 && y < 0) {
                    Console.WriteLine("quarto");
                }
            }
        }
    }
}