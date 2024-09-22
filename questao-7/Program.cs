using System;

namespace PilhaEncadeadaLIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha1 = new Pilha();
            Pilha pilha2 = new Pilha();

            Console.WriteLine("Testando transferência de elementos entre pilhas...\n");

            // Inserir algumas letras na pilha 1
            pilha1.push('H');
            pilha1.push('E');
            pilha1.push('L');
            pilha1.push('L');
            pilha1.push('O');

            // Imprimir a pilha original
            Console.WriteLine("Pilha original (Pilha1):");
            pilha1.imprimir();

            // Transferir elementos da Pilha1 para a Pilha2
            pilha1.transferir(pilha2);

            // Imprimir a pilha após a transferência
            Console.WriteLine("Pilha após transferência (Pilha2):");
            pilha2.imprimir();
        }
    }
}
