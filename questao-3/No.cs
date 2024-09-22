using System;

namespace PilhaEncadeadaLIFO
{
    public class No
    {
        public int valor;
        public No prox;

        public No(int Valor)
        {
            this.valor = Valor;
            this.prox = null;
        }
    }
}
