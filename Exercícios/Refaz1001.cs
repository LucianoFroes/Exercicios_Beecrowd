using System;

namespace Beecrowd.Exercícios {

    public class Operacoes {

        int A, B;

        public int Soma(int a, int b) {
            A = a;
            B = b;
            return a + b;
        } 
    }

     class Refaz1001 {
        public static void Executar(){

            var op = new Operacoes();

            int entradaA = int.Parse(Console.ReadLine());
            int entradaB = int.Parse(Console.ReadLine());

            int X = op.Soma(entradaA, entradaB);

            Console.WriteLine($"X = {X}");

        }
    }
}
