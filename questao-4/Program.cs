using System;

namespace PilhaEncadeadaLIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha1 = new Pilha();

            Console.WriteLine("Testando separação de números positivos e negativos...\n");

            // Inserir alguns números na pilha 1
            pilha1.push(1);
            pilha1.push(-2);
            pilha1.push(7);
            pilha1.push(-15);
            pilha1.push(51);
            pilha1.push(-23);

            // Imprimir a pilha original
            Console.WriteLine("Pilha original (Pilha1):");
            pilha1.imprimir();

            // Separar os números em Pilha2 (positivos) e Pilha3 (negativos)
            pilha1.separarPelasPilhas(out Pilha pilha2, out Pilha pilha3);

            // Imprimir a pilha de números positivos
            Console.WriteLine("\nPilha de números positivos (Pilha2):");
            pilha2.imprimir();

            // Imprimir a pilha de números negativos
            Console.WriteLine("\nPilha de números negativos (Pilha3):");
            pilha3.imprimir();
        }
    }
}
