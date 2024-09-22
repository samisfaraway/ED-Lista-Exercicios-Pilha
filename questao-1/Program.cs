using System;

namespace PilhaEncadeadaLIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma nova pilha
            Pilha pilha = new Pilha();

            Console.WriteLine("Testando operações da Pilha Encadeada LIFO...\n");

            // Teste da Operação PUSH (Inserção)
            Console.WriteLine("Inserindo documentos na pilha (PUSH):");
            pilha.push(new Documento("documento1", "txt", 100));
            pilha.push(new Documento("documento2", "pdf", 250));
            pilha.push(new Documento("documento3", "docx", 300));

            // Imprimir a pilha após PUSH
            Console.WriteLine("\nPilha após operações de PUSH:");
            pilha.imprimir();

            // Teste da Operação POP (Remoção)
            Console.WriteLine("\nRemovendo documentos da pilha (POP):");
            No removido1 = pilha.pop();
            No removido2 = pilha.pop();

            // Imprimir o valor dos nós removidos
            Console.WriteLine("\nDocumentos removidos:");
            if (removido1 != null) removido1.documento.imprimir();
            if (removido2 != null) removido2.documento.imprimir();

            // Imprimir a pilha após POP
            Console.WriteLine("\nPilha após operações de POP:");
            pilha.imprimir();

            // Teste da Operação de Consulta
            Console.WriteLine("\nConsultando se 'documento1' está na pilha:");
            No noAtual = null;
            No noAnterior = null;
            if (pilha.consulta("documento1", ref noAtual, ref noAnterior))
            {
                Console.WriteLine("Documento encontrado: ");
                noAtual.documento.imprimir();
            }
            else
            {
                Console.WriteLine("Documento não encontrado!");
            }

            // Teste da Operação de Impressão (Percurso)
            Console.WriteLine("\nImprimindo todos os documentos restantes na pilha:");
            pilha.imprimir();
        }
    }
}
