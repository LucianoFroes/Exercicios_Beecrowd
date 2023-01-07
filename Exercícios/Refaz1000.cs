using System;

namespace Beecrowd.Exercícios {

    public class Hello {

        string Frase = "Hello World!";

        public string HelloWorld() {
            return Frase;
        }
    }

     class Refaz1000 {
        public static void Executar() {

            var h = new Hello();
            Console.WriteLine(h.HelloWorld());

        }
    }
}
