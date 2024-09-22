using System;

namespace PilhaEncadeadaLIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            Console.WriteLine("Testando verificação de palíndromo...\n");

            // Inserir letras que formam um palíndromo
            pilha.push('R');
            pilha.push('A');
            pilha.push('D');
            pilha.push('A');
            pilha.push('R');

            // Imprimir a pilha original
            Console.WriteLine("Pilha original:");
            pilha.imprimir();

            // Verificar se a pilha forma um palíndromo
            bool resultado = pilha.ehPalindromo();
            Console.WriteLine($"A pilha forma um palíndromo? {resultado}");

            // Inserir letras que não formam um palíndromo
            Pilha pilhaNaoPalindromo = new Pilha();
            pilhaNaoPalindromo.push('P');
            pilhaNaoPalindromo.push('R');
            pilhaNaoPalindromo.push('O');
            pilhaNaoPalindromo.push('G');
            pilhaNaoPalindromo.push('R');
            pilhaNaoPalindromo.push('A');
            pilhaNaoPalindromo.push('M');
            pilhaNaoPalindromo.push('A');
            pilhaNaoPalindromo.push('R');

            // Imprimir a pilha não palíndromo
            Console.WriteLine("\nPilha não palíndromo:");
            pilhaNaoPalindromo.imprimir();

            // Verificar se a pilha não palíndromo forma um palíndromo
            resultado = pilhaNaoPalindromo.ehPalindromo();
            Console.WriteLine($"A pilha forma um palíndromo? {resultado}");
        }
    }
}
