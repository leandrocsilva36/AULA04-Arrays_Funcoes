// 3,3-3-Média dos Valores



int[] numeros = new int[6];
int soma = 0;

Console.WriteLine("Digite 6 números inteiros:");

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
    soma += numeros[i];
}


double media = soma / 6.0;

Console.WriteLine($"\nA média dos números digitados é: {media}");


