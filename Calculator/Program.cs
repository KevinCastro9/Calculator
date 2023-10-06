using Calculator.Structs;

try
{
    while (true)
    {
        Menu();
    }
    
}
catch (Exception Erro)
{
    Console.WriteLine("Ocorreu o erro: " + Erro.ToString() + ". Durante a operação, por gentileza tente novamente!!!");
    Console.ReadKey();

    System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
    Environment.Exit(0);
}

static void Menu()
{
    Console.Clear();

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("----------------------");
    Console.WriteLine("Por gentileza selecione a operação que deseja realizar ?");

    short operacao = short.Parse(Console.ReadLine());

    if (operacao == 5)
    {
        Environment.Exit(0);
    }

    if (operacao > 0 && operacao <= 4)
    {
        Console.WriteLine("Primeiro Valor: ");
        float primeiroValor = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float segundoValor = float.Parse(Console.ReadLine());

        var operacoes = new Operacoes(primeiroValor, segundoValor);

        switch (operacao)
        {
            case 1:
                Console.WriteLine("O resultado é " + operacoes.Soma().ToString() + ". Clique em qualquer tecla para continuar."); break;
            case 2:
                Console.WriteLine("O resultado é " + operacoes.Subtracao().ToString() + ". Clique em qualquer tecla para continuar."); break;
            case 3:
                Console.WriteLine("O resultado é " + operacoes.Multiplicacao().ToString() + ". Clique em qualquer tecla para continuar."); break;
            case 4:
                Console.WriteLine("O resultado é " + operacoes.Divisao().ToString() + ". Clique em qualquer tecla para continuar."); break;
            default:
                 break;
        }
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Por gentileza escolha uma das opções de operações. Clique em qualquer tecla para voltar!");
        Console.ReadKey();
    }
    
}
