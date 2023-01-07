using System;


namespace Beecrowd.Exercícios {

    public class Soma {

        static int valorA, valorB;  // Pelos testes, um método estático só pode usar variáveis estáticas.

        public static int SomaDoisNumeros(int a, int b) {
            valorA = a;
            valorB = b;

            return a + b;
        }
    }
     class Refaz1003 {
        public static void Executar() {

            int valorUm = int.Parse(Console.ReadLine());
            int valorDois = int.Parse(Console.ReadLine());

            int soma = Soma.SomaDoisNumeros(valorUm, valorDois);

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
