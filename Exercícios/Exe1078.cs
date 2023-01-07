using System;
using System.Transactions;

namespace Beecrowd.Exercícios {
     class Exe1078 {
        public static void Executar() {

            int numero = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++) {
                Console.WriteLine($"{i} x {numero} = {numero * i}");

            }
        }
    }
}
