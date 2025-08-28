// 6,2-Função de Busca em Array
//** Faça uma função que recebe um array e um número, retornando true se o número estiver no array e false caso contrário.


class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        Console.WriteLine("Digite 5 números inteiros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite um número para verificar se está no array: ");
        int numeroProcurado = int.Parse(Console.ReadLine());

        bool existe = VerificarNumero(numeros, numeroProcurado);

        if (existe)
            Console.WriteLine($"\nO número {numeroProcurado} está no array.");
        else
            Console.WriteLine($"\nO número {numeroProcurado} não está no array.");
    }
    static bool VerificarNumero(int[] array, int numero)
    {
        foreach (int n in array)
        {
            if (n == numero)
                return true;
        }
        return false;
    }
}
