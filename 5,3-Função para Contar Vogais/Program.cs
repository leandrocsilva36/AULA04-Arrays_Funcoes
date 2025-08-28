// 5,3-Função para Contar Vogais
//**Escreva uma função que recebe uma string e retorna a quantidade de vogais nela.

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine();

        int quantidadeVogais = ContarVogais(texto);

        Console.WriteLine($"\nA quantidade de vogais no texto é: {quantidadeVogais}");
    }
    static int ContarVogais(string s)
    {
        int contador = 0;
        string vogais = "aeiouAEIOU";

        foreach (char c in s)
        {
            if (vogais.Contains(c))
            {
                contador++;
            }
        }

        return contador;
    }
}

