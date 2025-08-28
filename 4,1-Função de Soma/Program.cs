// 4,1-Função de Soma
// ** Crie uma função que recebe dois números e retorna a soma deles.

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = Somar(num1, num2);

        Console.WriteLine($"\nA soma é: {resultado}");
    }
    static int Somar(int a, int b)
    {
        return a + b;
    }
}
