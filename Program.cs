namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("Selecione umas das opções abaixo: ");
        Console.WriteLine("");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------");

        short escolha = short.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Soma();
                break;
            case 2:
                Subtracao();
                break;
            case 3:
                Divisao();
                break;
            case 4:
                Multiplicacao();
                break;
            case 5:
                Exit();
                break;
            default:
                Invalido();
                break;
        }
    }

    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Informe o segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());
        float resultado = v1 + v2;

        Console.Clear();
        Console.WriteLine($"O valor total da soma é: {resultado}");
        // Console.WriteLine("O valor total da soma é: " + resultado);
        // Console.WriteLine("O valor total da soma é: " + (v1 + v2));
        // Console.WriteLine($"O valor total da soma é: {(v1 + v2)}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 - v2;
        Console.WriteLine($"O Resultado da subtração é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 / v2;
        Console.WriteLine($"O resultado da divisão dos valores é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 * v2;
        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Invalido()
    {
        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar e escolha um número entre 1 e 5");
        Console.WriteLine("");
        Console.ReadKey();
        Menu();
    }

    static void Exit()
    {
        Console.WriteLine("");
        Console.WriteLine("Obrigado por usar a nossa calculadora!");
        Console.WriteLine("");
        System.Environment.Exit(0);
    }
}
