using System;

namespace Beecrowd.Exercícios {
     class Exe1165 {

        static bool isPrime(int value) {
            for(int i = 2; i < value; i++) {
                if(value % i == 0) {
                    return false;
                }
            }

            return true;
        }
        public static void Executar() {

            int quantidade = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantidade; i++) {
                int numero = int.Parse(Console.ReadLine());

                string resp = $"{numero}";

                if (isPrime(numero)) {
                    resp += "eh primo ";
                }
                resp += "nao";
            }
        }
    }
}
