using System;
using System.Diagnostics;

namespace Beecrowd.Exercícios {
     class Exe1049 {
        public static void Executar() {

            string reinoAnimal = Console.ReadLine();
            string etapa1 = "";
            string etapa2 = "";

            switch (reinoAnimal) {

                case "vertebrado":
                    etapa1 = Console.ReadLine();

                    switch (etapa1) {

                        case "ave":
                            etapa2= Console.ReadLine();

                            switch (etapa2) {
                                case "carnivoro":
                                    Console.WriteLine("aguia");
                                    break;

                                case "onivoro":
                                    Console.WriteLine("pomba");
                                    break;
                            }   
                            break;

                        case "mamifero":
                            etapa2 = Console.ReadLine();

                            switch (etapa2) {
                                case "onivoro":
                                    Console.WriteLine("homem");
                                    break;

                                case "herbivoro":
                                    Console.WriteLine("vaca");
                                    break;
                            }
                            break;
                    }
                    break;

                case "invertebrado":
                    etapa1 = Console.ReadLine();

                    switch (etapa1) {
                        case "inseto":
                            etapa2 = Console.ReadLine();

                            switch (etapa2) {
                                case "hematofago":
                                    Console.WriteLine("pulga");
                                    break;
                            }

                            switch(etapa2) {
                                case "herbivoro":
                                    Console.WriteLine("lagarta");
                                    break;  
                            }
                            break;
                    }

                    switch (etapa1) {
                        case "anelideo":
                            etapa2 = Console.ReadLine();

                            switch (etapa2) {
                                case "hematofago":
                                    Console.WriteLine("sanguessuga");
                                    break;
                            }

                            switch (etapa2) {
                                case "onivoro":
                                    Console.WriteLine("minhoca");
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
