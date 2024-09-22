using System;

namespace PilhaEncadeadaLIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            Console.WriteLine("Testando contagem de números ímpares na pilha...\n");

            // Inserir alguns números na pilha
            pilha.push(1);
            pilha.push(2);
            pilha.push(3);
            pilha.push(4);
            pilha.push(5);
            pilha.push(6);
            pilha.push(7);

            // Imprimir a pilha
            Console.WriteLine("\nImprimindo a pilha:");
            pilha.imprimir();

            // Contar os números ímpares da pilha
            int numeroImpares = pilha.contarImpares();
            Console.WriteLine($"\nNúmero de elementos ímpares na pilha: {numeroImpares}");

            // Remover dois elementos
            pilha.pop();
            pilha.pop();

            // Imprimir a pilha após remoção
            Console.WriteLine("\nImprimindo a pilha após remoção:");
            pilha.imprimir();

            // Contar os números ímpares novamente
            numeroImpares = pilha.contarImpares();
            Console.WriteLine($"\nNúmero de elementos ímpares na pilha após remoção: {numeroImpares}");
        }
    }
}
