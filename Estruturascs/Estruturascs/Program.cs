using System;
using System.Collections.Generic;
using Random_nomedalib_;

namespace Estruturascs {
    internal class Program {

            // Struct (Lembra uma classe, mais nao permite polimorfismo, herança, etc) -> é como se fosse uma classe limitada

            struct Carro {

                public string Marca;
                public string Modelo;
                public string Cor;
                public string Placa;

                public Carro(string marca, string modelo, string cor, string placa) { // Construtor da struct
                    Marca = marca;
                    Modelo = modelo;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;; // Melhor sobrar do que faltar
                    Cor = cor;
                    Placa = placa;
                }

                public void showData() {
                    Console.WriteLine("Marca: " + Marca);
                    Console.WriteLine("Modelo: " + Modelo);
                    Console.WriteLine("Cor: " + Cor);
                    Console.WriteLine("Placa: " + Placa);
                }

            }

        static void Main(string[] args) {

            // Carro carro2 = new Carro("Ford", "Ka", "Azul", "ABC-1234");

            // carro2.showData();

            /*
            Carro carro = new Carro();

            carro.Marca = "Ford";
            carro.Modelo = "Fusion";
            carro.Placa = "SENTI91";
            carro.Cor = "Preto";

            Console.WriteLine("Marca: " + carro.Marca);
            Console.WriteLine("Modelo: " + carro.Modelo);
            Console.WriteLine("Placa: " + carro.Placa);
            Console.WriteLine("Cor: " + carro.Cor);
            // Queue - Filas

            Queue<string> fila = new Queue<string>();

            fila.Enqueue("José");
            fila.Enqueue("Bruna");
            fila.Enqueue("Gui");

            Console.WriteLine($"Numero de pessoas na fila: {fila.Count}");
            Console.WriteLine($"Próximo da fila: {fila.Peek()}");

            Console.WriteLine($"Sr: {fila.Dequeue()}, aqui está seu café");

            // Stack - Pilhas

            Stack<int> pilha = new Stack<int>();

            pilha.Push(12); // Adiciona elemento na pilha
            pilha.Push(13);
            pilha.Push(14);
            pilha.Push(15);

            foreach (int i in pilha) {
                Console.WriteLine(i);
            }

            pilha.Pop(); // Remove elemento da pilha
*/

            // List
            /*

            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro("Ford", "Ka", "Azul", "ABC-1234"));
            carros.Add(new Carro("Honda", "Ab", "Rosa", "CBA-2144"));
            carros.Add(new Carro("Fiat", "Uno", "Vermelho", "BCA-1314"));

            foreach (Carro carro in carros) {

                carro.showData();
                Console.WriteLine();
            }

            var teste = carros.Contains(new Carro("Ford", "Ka", "Azul", "ABC-1234")) ? "Sim" : "Não";

            Console.WriteLine(teste);

            */

            if (Usuario.EfetuarLogin("nome", "senac")) { 
                // logado com sucesso
            }

            Usuario usuario = new Usuario("Zé", "ze@dotcom", "12345", new Nivel("Caixa","cx"));

            Console.WriteLine("{0}, {1}", usuario.Nome, usuario.Nivel.Nome);

            // usuario.Id = 10;
            Nivel nivel = new Nivel();

            nivel.Alterar(1, "cx");
            Console.ReadKey();
        }
    }
}
