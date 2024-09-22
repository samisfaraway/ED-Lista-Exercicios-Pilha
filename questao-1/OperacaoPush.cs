using System;

namespace PilhaEncadeadaLIFO
{
    class OperacaoPop
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            // Inserir alguns documentos
            pilha.push(new Documento("documento1", "txt", 100));
            pilha.push(new Documento("documento2", "pdf", 250));
            pilha.push(new Documento("documento3", "docx", 300));

            // Remover documentos da pilha
            Console.WriteLine("Removendo documentos...");
            pilha.pop();
            pilha.pop();
            pilha.pop();

            // Imprimir novamente após remoção
            Console.WriteLine("Imprimindo a pilha após POP:");
            pilha.imprimir();
        }
    }
}
