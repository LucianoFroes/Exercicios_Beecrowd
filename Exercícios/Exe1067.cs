using System;


namespace Beecrowd.Exercícios {
     class Exe1067 {
       public static void Executar() {

            int valorInteiro = int.Parse(Console.ReadLine());

            for(int i = 1; i <= valorInteiro; i+= 2) {

                if(i % 2 != 0) {
                    Console.WriteLine(i);
                }
                   
            }
        }
    }
}
