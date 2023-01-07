using System;


namespace Beecrowd.Exercícios {
     class Exe1113 {
        public static void Executar() {

            while (true) {

                string[] valores = Console.ReadLine().Split();

                int valor1 = int.Parse(valores[0]);
                int valor2 = int.Parse(valores[1]);

                if(valor1 > valor2) {
                    Console.WriteLine("Decrescente");

                } else if (valor1 < valor2){
                    Console.WriteLine("Crescente");
                } else {
                    break;
                }
            }
        }
    }
}
