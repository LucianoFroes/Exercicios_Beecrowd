using System;


namespace Beecrowd.Exercícios {
     class Exe2454 {
        public static void Executar() {

            string[] valores = Console.ReadLine().Split();

            int p = int.Parse(valores[0]);
            int r = int.Parse(valores[1]);

            if(p == 0) {
                Console.WriteLine("C");
                
            } else if(r == 0) {
                Console.WriteLine("B");
            } else {
                Console.WriteLine("A");
            }
        }
    }
}
