// 2,3-Frequência de um Número
// Peça ao usuário 10 números e um número adicional. O programa deve contar e exibir quantas vezes esse número aparece no array.

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int contador = 0;

        Console.WriteLine("Digite 10 números inteiros:");

        
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        
        Console.Write("\nDigite um número para contar quantas vezes aparece: ");
        int numeroProcurado = int.Parse(Console.ReadLine());

     
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numeroProcurado)
            {
                contador++;
            }
        }

        Console.WriteLine($"\nO número {numeroProcurado} aparece {contador} vezes no array.");
    }
}

