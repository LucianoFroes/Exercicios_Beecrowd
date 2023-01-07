using System;


namespace Beecrowd.Exercícios {
     class Exe1060 {
        public static void Executar() {

            double[] valoresArray = new double[6];
            int qntPositivos = 0;

            for(int i = 0; i <= 5; i++) {
                valoresArray[i] = double.Parse(Console.ReadLine());

                if (valoresArray[i] > 0) {
                    qntPositivos++;
                }
            }

            Console.WriteLine($"{qntPositivos} valores positivos");
        }
    }
}
