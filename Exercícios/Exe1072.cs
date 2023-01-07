using System;


namespace Beecrowd.Exercícios {
     class Exe1072 {
        public static void Executar() {

            int qntValores = int.Parse(Console.ReadLine());
            int[] arrayNum = new int[qntValores];
            int dentro = 0;
            int fora = 0;

            for(int i = 0; i <= qntValores - 1; i++) {
                arrayNum[i] = int.Parse(Console.ReadLine());

                if (arrayNum[i] >= 10 && arrayNum[i] <= 20) {
                    dentro++;

                } else {
                    fora++;
                }

            }
            Console.WriteLine($"{dentro} in\n{fora} out");
        }
    }
}
