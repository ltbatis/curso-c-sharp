using System;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            Console.WriteLine("Digite seu nome: ");
            sicrano.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int.TryParse(Console.ReadLine(), out sicrano.Idade);

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
