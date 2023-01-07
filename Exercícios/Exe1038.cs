using System;


namespace Beecrowd.Exercícios {
     class Exe1038 {
        public static void Executar() {

            string[] dados = Console.ReadLine().Split();

            double codProduto = double.Parse(dados[0]);
            double quantProduto = double.Parse(dados[1]);

            double carrinho = 0;

            if (codProduto == 1) {
                carrinho = 4.00 * quantProduto;
            } else if (codProduto == 2) {
                carrinho = 4.50 * quantProduto;
            } else if (codProduto == 2) {
                carrinho = 4.50 * quantProduto;
            } else if (codProduto == 3) {
                carrinho = 5.0 * quantProduto;
            } else if (codProduto == 4) {
                carrinho = 2.0 * quantProduto;
            } else if (codProduto == 5) {
                carrinho = 1.50 * quantProduto;
            }

            Console.WriteLine($"Total: R$ {carrinho:F2}");

        }
    }
}
