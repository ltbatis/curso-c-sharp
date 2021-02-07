using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaForEach {
        public static void Executar() {
            var palavra = "Lucas";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }
        }
    }
}
