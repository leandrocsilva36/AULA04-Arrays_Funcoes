// 5,1-Função de Fatorial
//** Implemente uma função que recebe um número e retorna seu fatorial.

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        long fatorial = CalcularFatorial(numero);

        Console.WriteLine($"\nO fatorial de {numero} é {fatorial}.");
    }

    static long CalcularFatorial(int n)
    {
        long resultado = 1;

        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}
