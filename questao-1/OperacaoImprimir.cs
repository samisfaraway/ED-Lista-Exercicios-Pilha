using System;

namespace PilhaEncadeadaLIFO
{
    class OperacaoImprimir
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            // Inserir documentos na pilha
            pilha.push(new Documento("documento1", "txt", 100));
            pilha.push(new Documento("documento2", "pdf", 250));
            pilha.push(new Documento("documento3", "docx", 300));

            // Impressão dos documentos
            Console.WriteLine("Imprimindo a pilha:");
            pilha.imprimir();
        }
    }
}
