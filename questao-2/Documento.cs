using System;

namespace PilhaEncadeadaLIFO
{
    public class Documento
    {
        public string nomeDoArquivo;
        public string extensaoDoArquivo;
        public int tamanhoDoArquivo;

        public Documento(string nome, string extensao, int tamanho)
        {
            this.nomeDoArquivo = nome;
            this.extensaoDoArquivo = extensao;
            this.tamanhoDoArquivo = tamanho;
        }

        public void imprimir()
        {
            Console.WriteLine($"Documento: {nomeDoArquivo}.{extensaoDoArquivo}, Tamanho: {tamanhoDoArquivo} KB");
        }
    }
}
