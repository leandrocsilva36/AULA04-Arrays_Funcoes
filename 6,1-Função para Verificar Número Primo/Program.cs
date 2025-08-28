// 6,1-Função para Verificar Número Primo
//**Crie uma função que recebe um número e retorna se ele é primo ou não.

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        bool ehPrimo = VerificarPrimo(numero);

        if (ehPrimo)
            Console.WriteLine($"\nO número {numero} é primo.");
        else
            Console.WriteLine($"\nO número {numero} não é primo.");
    }

    static bool VerificarPrimo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}

