using System;

namespace Beecrowd.Exercícios {
    class Exe1116 {
        public static void Executar() {

            int qntRepeticoes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qntRepeticoes; i++) {

                string[] valoresInt = Console.ReadLine().Split();

                int x = int.Parse(valoresInt[0]);
                int y = int.Parse(valoresInt[1]);

                if (y == 0) {
                    Console.WriteLine("divisao impossivel");

                } else {
                    double divisao = (double)x / (double)y;

                    Console.WriteLine($"{divisao:F1}");
                }
            }
        }
    }
}
