// 3,3-Intersecção de Arrays
//**O usuário insere dois arrays de 5 elementos. O programa exibe quais números aparecem em ambos

class Program
{
    static void Main()
    {
        int[] array1 = new int[5];
        int[] array2 = new int[5];

        Console.WriteLine("Digite 5 números para o primeiro array:");
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDigite 5 números para o segundo array:");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros que aparecem em ambos os arrays:");

   
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[i] == array2[j])
                {
                    Console.WriteLine(array1[i]);
                    break; 
                }
            }
        }
    }
}

