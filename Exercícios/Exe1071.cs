using System;

namespace Beecrowd.Exercícios {
    class Exe1071 {
        public static void Executar() {

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int min, max;
            int somaImpares = 0;

            if (X < Y) {
                min = X;
                max = Y;
            } else {
                min = Y;
                max = X;
            }

            for (int i = min + 1; i < max; i++) {

                if (i % 2 != 0) {
                    somaImpares += i;
                }
            }

            Console.WriteLine(somaImpares);

        }
    }
}
