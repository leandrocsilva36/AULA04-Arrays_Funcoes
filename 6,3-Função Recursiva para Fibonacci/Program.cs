// 6,3-Função Recursiva para Fibonacci
//**Implemente uma função recursiva que recebe um número n e retorna o nésimo termo da sequência de Fibonacci.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro n para calcular o n-ésimo termo de Fibonacci: ");
        int n = int.Parse(Console.ReadLine());

        long fibonacci = Fibonacci(n);

        Console.WriteLine($"\nO {n}-ésimo termo da sequência de Fibonacci é: {fibonacci}");
    }
    static long Fibonacci(int n)
    {
        if (n <= 0)
            return 0; 
        else if (n == 1)
            return 1; 
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2); 
    }
}

