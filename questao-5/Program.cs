using System;

namespace PilhaEncadeadaLIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            Console.WriteLine("Testando inversão de letras na pilha...\n");

            // Inserir algumas letras na pilha
            pilha.push('E');
            pilha.push('U');
            pilha.push('A');
            pilha.push('M');
            pilha.push('O');
            pilha.push('P');
            pilha.push('R');
            pilha.push('O');
            pilha.push('G');
            pilha.push('R');
            pilha.push('A');
            pilha.push('M');
            pilha.push('A');
            pilha.push('R');

            // Imprimir a pilha original
            Console.WriteLine("Pilha original:");
            pilha.imprimir();

            // Inverter a ordem das letras
            pilha.inverter();

            // Imprimir a pilha após inversão
            Console.WriteLine("Pilha após inversão:");
            pilha.imprimir();
        }
    }
}
