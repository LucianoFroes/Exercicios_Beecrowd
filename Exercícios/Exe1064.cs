using System;


namespace Beecrowd.Exercícios {
    class Exe1064 {
        public static void Executar() {

            double[] valoresArray = new double[6];
            int qntPositivos = 0;
            double media = 0;

            for (int i = 0; i <= 5; i++) {
                valoresArray[i] = double.Parse(Console.ReadLine());

                if (valoresArray[i] > 0) {
                    qntPositivos++;
                    media += valoresArray[i];
                }
            }

            media = media / qntPositivos;

            Console.WriteLine($"{qntPositivos} valores positivos");
            Console.WriteLine($"{media:F1}");
        }
    }
}
