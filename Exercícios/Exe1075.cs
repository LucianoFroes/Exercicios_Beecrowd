using System;

namespace Beecrowd.Exercícios {
     class Exe1075 {
        public static void Executar() {

            int numero = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10000; i++) {

                if(i % numero == 2) {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
