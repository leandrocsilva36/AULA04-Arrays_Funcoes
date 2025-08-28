// 2,1-Contagem de Números Pares

//Peça ao usuário 10 números, armazene em um array e exiba a quantidade de números pares inseridos.




class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int contPares = 0;

        Console.WriteLine("Digite 10 números inteiros:");

        
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0) 
            {
                contPares++;
            }
        }

        Console.WriteLine($"\nQuantidade de números pares digitados: {contPares}");
    }
}