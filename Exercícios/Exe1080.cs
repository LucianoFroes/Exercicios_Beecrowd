using System;

namespace Beecrowd.Exercícios {
     class Exe1080 {
        public static void Executar() {

            int maiorValor = 0;
            int posicao = 1;

            for (int i = 1; i <= 100; i++) {
                int valores = int.Parse(Console.ReadLine());

                for(int j = 0; j <= 1; j++) {
                    
                    if(maiorValor < valores) {
                        maiorValor = valores;
                        posicao = i;
                    }
                }
                
            }
            Console.WriteLine($"{maiorValor}\n{posicao}");
        }
    }
}
