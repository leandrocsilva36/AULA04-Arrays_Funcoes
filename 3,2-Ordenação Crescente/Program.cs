// 3,2-Ordenação Crescente
// Peça 10 números ao usuário e exiba-os em ordem crescente.

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");

       
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numeros);

        Console.WriteLine("\nNúmeros em ordem crescente:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}

