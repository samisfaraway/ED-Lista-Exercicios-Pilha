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

        public void push(char letra)
        {
            No novoNo = new No(letra);

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
                Console.Write(noAux.letra);
                noAux = noAux.prox;
            }
            Console.WriteLine();
        }

        // Método para verificar se a pilha forma um palíndromo (Questão 6)
        public bool ehPalindromo()
        {
            Pilha pilhaAux = new Pilha();
            No noAtual = this.topo;

            // Transferir os elementos para uma pilha auxiliar
            while (noAtual != null)
            {
                pilhaAux.push(noAtual.letra);
                noAtual = noAtual.prox;
            }

            // Comparar os elementos da pilha original e da pilha auxiliar
            noAtual = this.topo;
            while (noAtual != null)
            {
                if (noAtual.letra != pilhaAux.pop().letra)
                {
                    return false; // Não é palíndromo
                }
                noAtual = noAtual.prox;
            }

            return true; // É palíndromo
        }
    }
}
