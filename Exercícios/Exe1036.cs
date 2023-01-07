using System;

namespace Beecrowd.Exercícios {
    class Exe1036 {
        public static void Executar() {

            string[] vetorABC = Console.ReadLine().Split();

            double valorA = double.Parse(vetorABC[0]);
            double valorB = double.Parse(vetorABC[1]);
            double valorC = double.Parse(vetorABC[2]);

            double delta = Math.Pow(valorB, 2) - (4 * valorA* valorC);
            double raiz = Math.Sqrt(delta);

            double baskharaR1 = (- valorB + raiz) / (2 * valorA);
            double baskharaR2 = (- valorB - raiz) / (2 * valorA);

            if (delta < 0 || valorA == 0 || valorB == 0 || valorC == 0) {
                Console.WriteLine("Impossivel calcular");
            } else {
                Console.WriteLine($"R1 = {baskharaR1:F5}\nR2 = {baskharaR2:F5}");
            }
        }
    }
}
