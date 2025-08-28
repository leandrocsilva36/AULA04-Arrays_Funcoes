// 5,2-Função para Inverter String
//**Faça uma função que recebe uma string e retorna a string invertida.


class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine();

        string invertido = InverterString(texto);

        Console.WriteLine($"\nTexto invertido: {invertido}");
    }

    static string InverterString(string s)
    {
        char[] caracteres = s.ToCharArray();
        Array.Reverse(caracteres);          
        return new string(caracteres);       
    }
}

