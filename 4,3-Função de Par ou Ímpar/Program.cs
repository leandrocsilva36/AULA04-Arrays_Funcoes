// 4,3-Função de Par ou Ímpar
//**Escreva uma função que recebe um número e retorna "Par" ou "Ímpar".


class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        string resultado = VerificarParOuImpar(numero);

        Console.WriteLine($"\nO número {numero} é {resultado}.");
    }

    static string VerificarParOuImpar(int n)
    {
        if (n % 2 == 0)
        {
            return "Par";
        }
        else
        {
            return "Ímpar";
        }
    }
}

