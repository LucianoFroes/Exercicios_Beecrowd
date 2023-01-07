using System;

namespace Beecrowd.Exercícios {
    class Exe1074 {
        public static void Executar() {

            int numRepeticao = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numRepeticao; i++) {

                int valor = int.Parse(Console.ReadLine());

                if (valor % 2 == 0 && valor > 0) {
                    Console.WriteLine("EVEN POSITIVE");

                } else if (valor % 2 != 0 && valor > 0) {
                    Console.WriteLine("ODD POSITIVE");

                } else if (valor % 2 == 0 && valor < 0) {
                    Console.WriteLine("EVEN NEGATIVE");

                } else if (valor % 2 != 0 && valor < 0) {
                    Console.WriteLine("ODD NEGATIVE");

                } else if (valor == 0) {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
