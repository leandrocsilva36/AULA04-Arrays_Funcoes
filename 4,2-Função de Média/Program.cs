// 4,2-Função de Média
//** Faça uma função que recebe um array de números e retorna a média dos valores.


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

        double media = CalcularMedia(numeros);

        Console.WriteLine($"\nA média dos números é: {media}");
    }

    static double CalcularMedia(int[] valores)
    {
        int soma = 0;

        for (int i = 0; i < valores.Length; i++)
        {
            soma += valores[i];
        }

        return soma / (double)valores.Length;
    }
}

