using System;

namespace Beecrowd.Exercícios {
    class Exe1010 {
        public static void Executar() {

            string[] linha1 = Console.ReadLine().Split();
            string[] linha2 = Console.ReadLine().Split();

            int codPeca1 = int.Parse(linha1[0]);
            int codPeca2 = int.Parse(linha2[0]);

            int numPeca1 = int.Parse(linha1[1]);
            int numPeca2 = int.Parse(linha2[1]);

            double valPeca1 = double.Parse(linha1[2]);
            double valPeca2 = double.Parse(linha2[2]);

            double carrinho = (numPeca1 * valPeca1) + (numPeca2 * valPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {carrinho:F2}");






        }
    }
}
