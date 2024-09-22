using System;

namespace PilhaEncadeadaLIFO
{
    public class No
    {
        public char letra;
        public No prox;

        public No(char letra)
        {
            this.letra = letra;
            this.prox = null;
        }
    }
}
