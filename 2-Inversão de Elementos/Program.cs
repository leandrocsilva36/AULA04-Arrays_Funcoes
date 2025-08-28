// 1,2 Maior e Menor Valor
//Peça ao usuário 10 números e armazene-os em um array. Em seguida, exiba o maior e o menor valor inserido





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

       
        int maior = numeros[0];
        int menor = numeros[0];

       
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
                maior = numeros[i];

            if (numeros[i] < menor)
                menor = numeros[i];
        }

        Console.WriteLine($"\nMaior número digitado: {maior}");
        Console.WriteLine($"Menor número digitado: {menor}");
    }
}