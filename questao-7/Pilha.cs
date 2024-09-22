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

        // Método para transferir os elementos para outra pilha preservando a ordem (Questão 7)
        public void transferir(Pilha pilhaDestino)
        {
            Pilha pilhaAux = new Pilha();

            // Transferir todos os elementos para a pilha auxiliar
            while (!this.estaVazia())
            {
                pilhaAux.push(this.pop().letra);
            }

            // Transferir os elementos da pilha auxiliar para a pilha destino
            while (!pilhaAux.estaVazia())
            {
                pilhaDestino.push(pilhaAux.pop().letra);
            }
        }
    }
}
