using System;

namespace PilhaEncadeadaLIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            Console.WriteLine("Testando contagem de elementos da pilha...\n");

            // Inserir alguns documentos na pilha
            pilha.push(new Documento("documento1", "txt", 100));
            pilha.push(new Documento("documento2", "pdf", 250));
            pilha.push(new Documento("documento3", "docx", 300));

            // Imprimir a pilha
            Console.WriteLine("\nImprimindo a pilha:");
            pilha.imprimir();

            // Contar os elementos da pilha
            int numeroElementos = pilha.contarElementos();
            Console.WriteLine($"\nNúmero de elementos na pilha: {numeroElementos}");

            // Remover dois elementos
            pilha.pop();
            pilha.pop();

            // Imprimir a pilha após remoção
            Console.WriteLine("\nImprimindo a pilha após remoção:");
            pilha.imprimir();

            // Contar os elementos novamente
            numeroElementos = pilha.contarElementos();
            Console.WriteLine($"\nNúmero de elementos na pilha após remoção: {numeroElementos}");
        }
    }
}
