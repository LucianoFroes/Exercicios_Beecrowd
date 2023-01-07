using System;

namespace Beecrowd.Exercícios {
    class Exe1114 {
        public static void Executar() {

            int password = 0;
            int access = 2002;

            while (password != access) {
                password = int.Parse(Console.ReadLine());

                if (password == access) {
                    Console.WriteLine("Acesso Permitido");
                } else {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}
