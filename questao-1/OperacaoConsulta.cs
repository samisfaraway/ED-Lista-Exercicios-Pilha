using System;

namespace PilhaEncadeadaLIFO
{
    class OperacaoConsulta
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            // Inserir documentos
            pilha.push(new Documento("documento1", "txt", 100));
            pilha.push(new Documento("documento2", "pdf", 250));
            pilha.push(new Documento("documento3", "docx", 300));

            // Consulta de um documento
            No noAtual = null;
            No noAnterior = null;
            Console.WriteLine("Consultando documento2:");
            if (pilha.consulta("documento2", ref noAtual, ref noAnterior))
            {
                Console.WriteLine("Documento encontrado!");
            }
            else
            {
                Console.WriteLine("Documento não encontrado!");
            }
        }
    }
}
