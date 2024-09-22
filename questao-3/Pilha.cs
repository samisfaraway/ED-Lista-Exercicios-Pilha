using System;

namespace PilhaEncadeadaLIFO
{
    public class Pilha
    {
        public No topo;

        public Pilha()
        {
            this.topo = null;
        }

        public Boolean estaVazia()
        {
            return (this.topo == null);
        }

        public void push(int valor)
        {
            No novoNo = new No(valor);

            if (this.estaVazia())
            {
                this.topo = novoNo;
            }
            else
            {
                novoNo.prox = this.topo;
                this.topo = novoNo;
            }
        }

        public No pop()
        {
            No aux = null;
            if (this.estaVazia())
            {
                return aux;
            }
            else
            {
                aux = this.topo;
                this.topo = this.topo.prox;
                return aux;
            }
        }

        public void imprimir()
        {
            No noAux = this.topo;
            Console.WriteLine("Elementos na pilha:");
            while (noAux != null)
            {
                Console.WriteLine(noAux.valor);
                noAux = noAux.prox;
            }
        }

        // Método para contar quantos números ímpares existem na pilha (Questão 3)
        public int contarImpares()
        {
            int contador = 0;
            No noAtual = this.topo;

            while (noAtual != null)
            {
                if (noAtual.valor % 2 != 0) // Verifica se o valor é ímpar
                {
                    contador++;
                }
                noAtual = noAtual.prox;
            }

            return contador;
        }
    }
}
