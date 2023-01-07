using System;

namespace Beecrowd.Exercícios {
     class Exe1073 {
        public static void Executar() {

            int qntValores = int.Parse(Console.ReadLine());
            double dobro = 0;

            for(int i = 1; i <= qntValores; i++) {
                dobro = Math.Pow(i, 2);

                if(i % 2 == 0) {
                    Console.WriteLine($"{i}^2 = {dobro}");

                }
            }
        }
    }
}
