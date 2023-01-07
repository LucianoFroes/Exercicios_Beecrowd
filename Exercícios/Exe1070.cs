using System;


namespace Beecrowd.Exercícios {
     class Exe1070 {
        public static void Executar() {

            int valorInteiro = int.Parse(Console.ReadLine());
            int contador = 0;

            while(contador < 6) {
                if(valorInteiro % 2 != 0) {
                    contador++;
                    Console.WriteLine(valorInteiro);
                }
                valorInteiro++;
            }
        }
    } 
}
