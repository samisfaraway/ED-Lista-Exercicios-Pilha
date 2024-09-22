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

        // Método para transferir números positivos e negativos
        public void transferirNumeros(Pilha pilhaPositiva, Pilha pilhaNegativa)
        {
            No noAtual = this.topo;

            while (noAtual != null)
            {
                if (noAtual.valor >= 0)
                {
                    pilhaPositiva.push(noAtual.valor);
                }
                else
                {
                    pilhaNegativa.push(noAtual.valor);
                }
                noAtual = noAtual.prox;
            }
        }
    }
}
