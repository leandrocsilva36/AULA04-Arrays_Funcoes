// See 2,2-Inversão de Elementos

//*Crie um programa que recebe 8 números em um array e exibe os valores na ordem inversa à que foram inseridos


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