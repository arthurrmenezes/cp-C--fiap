Console.WriteLine("Olá, bem-vindo!");
Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");

bool continuar = true;

while (continuar)
{
    int opcao = MostrarMenu();

    if (opcao == 5)
    {
        Console.WriteLine("Encerrando o programa...");
        continuar = false;
        break;
    }

    Console.WriteLine("Digite o primeiro número: ");
    double numero1 = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite o segundo número: ");
    double numero2 = double.Parse(Console.ReadLine()!);

    Calcular(opcao, numero1, numero2);

    Console.Write("Deseja continuar? (S/N): ");
    string resposta = Console.ReadLine();

    if (resposta == null || resposta.ToUpper() != "S")
    {
        continuar = false;
    }
}

int MostrarMenu()
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");
    Console.Write("Opção: ");

    int opcao;
    int.TryParse(Console.ReadLine(), out opcao);
    return opcao;
}

double LerNumero(string mensagem)
{
    double numero;
    Console.Write(mensagem);

    while (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.Write("Número inválido. Digite novamente: ");
    }

    return numero;
}

void Calcular(int opcao, double n1, double n2)
{
    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Resultado: {n1 + n2}");
            break;

        case 2:
            Console.WriteLine($"Resultado: {n1 - n2}");
            break;

        case 3:
            Console.WriteLine($"Resultado: {n1 * n2}");
            break;

        case 4:
            if (n2 == 0)
                Console.WriteLine("Erro: divisão por zero.");
            else
                Console.WriteLine($"Resultado: {n1 / n2}");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}