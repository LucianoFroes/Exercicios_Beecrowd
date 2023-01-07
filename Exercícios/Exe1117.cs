using System;


namespace Beecrowd.Exercícios {
    class Exe1117 {
        public static void Executar() {

            double valorUmAprovado = 0;
            double valorDoisAprovado = 0;

            while (true) {

                double valorUm = double.Parse(Console.ReadLine());

                if (valorUm > 10.0 || valorUm < 0.0) {
                    Console.WriteLine("nota invalida");
                } else {
                    valorUmAprovado = valorUm;
                    break;
                }

            }

            while (true) {

                double valorDois = double.Parse(Console.ReadLine());

                if (valorDois > 10.0 || valorDois < 0.0) {
                    Console.WriteLine("nota invalida");
                } else {
                    valorDoisAprovado = valorDois;
                    break;
                }

            }
            double media = (valorUmAprovado + valorDoisAprovado) / 2;

            Console.WriteLine($"media = {media:F2}");

        }
    }
}
