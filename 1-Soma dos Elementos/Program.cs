// 1,1-SOMA DOS ELEMENTOS
//Crie um programa que receba 5 números inteiros, armazene-os em um array e exiba a soma total dos elementos.


int[] numeros = new int[5];
int soma = 0;

Console.WriteLine("Digite 5 números inteiros:");

for (int x = 0; x < 5; x++)
{
    Console.Write($"Número {x + 1}: ");
    numeros[x] = Convert.ToInt32 (Console.ReadLine());
    soma = soma + numeros[x];
}

Console.WriteLine($"\nA soma dos números é: {soma}");
