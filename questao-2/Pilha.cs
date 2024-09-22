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

        public void push(Documento doc)
        {
            No novoNo = new No(doc);

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
                noAux.documento.imprimir();
                noAux = noAux.prox;
            }
        }

        // Método para contar quantos elementos a pilha possui (Questão 2)
        public int contarElementos()
        {
            int contador = 0;
            No noAtual = this.topo;

            while (noAtual != null)
            {
                contador++;
                noAtual = noAtual.prox;
            }

            return contador;
        }
    }
}
