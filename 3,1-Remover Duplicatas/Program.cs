// Remover Duplicatas
//Receba 10 números em um array e exiba-os sem valores duplicados.


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

        Console.WriteLine("\nNúmeros sem duplicatas:");

      
        for (int i = 0; i < numeros.Length; i++)
        {
            bool duplicado = false;

           
            for (int j = 0; j < i; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    duplicado = true;
                    break;
                }
            }
            if (!duplicado)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
