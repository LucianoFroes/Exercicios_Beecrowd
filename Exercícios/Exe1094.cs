using System;

namespace Beecrowd.Exercícios {
     class Exe1094 {
        public static void Executar() {

            int totalCobaias = 0;
            int totalCoelhos = 0;
            int totalSapos = 0;
            int totalRatos = 0;


            int numExperiencias = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numExperiencias; i++) {

                string[] cobaiasArray = Console.ReadLine().Split();

                int qntCobaia = int.Parse(cobaiasArray[0]);
                string cobaia = cobaiasArray[1].ToUpper();

                totalCobaias+= qntCobaia;

                if(cobaia == "C") {
                    totalCoelhos += qntCobaia;
                }else if(cobaia == "S") {
                    totalSapos += qntCobaia;
                } else {
                    totalRatos += qntCobaia;
                }
            }

            Console.WriteLine($"Total: {totalCobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {totalCoelhos}");
            Console.WriteLine($"Total de ratos: {totalRatos}");
            Console.WriteLine($"Total de sapos: {totalSapos}");

            double porcentagemCoelhos = (totalCoelhos * 100.00) / totalCobaias;
            double porcentagemSapos = (totalSapos * 100.00) / totalCobaias;
            double porcentagemRatos = (totalRatos * 100.00) / totalCobaias;

            Console.WriteLine($"Percentual de coelhos: {porcentagemCoelhos:F2} %");
            Console.WriteLine($"Percentual de ratos: {porcentagemRatos:F2} %");
            Console.WriteLine($"Percentual de sapos: {porcentagemSapos:F2} %");
        }
    }
}
