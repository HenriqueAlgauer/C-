string mensagem = "Boas vindas";

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();

bandas.Add("Link", new List<int> { 10, 8, 9, 7 });
bandas.Add("SOD", new List<int> { 1, 8, 5, 7 });
bandas.Add("BS", new List<int> { 8, 5, 7 });
bandas.Add("Dk", new List<int>());

void VoltarAoMenu(){
    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ExibirLogo()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
    Console.WriteLine(mensagem);
}

void ExibirTitulo(string titulo)
{
    int qntLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qntLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro de banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada.");
    VoltarAoMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("Exibindo todas as bandas registradas =)");
    foreach (string banda in bandas.Keys){
        Console.WriteLine($"Banda: {banda}");
    }
    VoltarAoMenu();
}

void MostrarAvaliacao()
{
    Console.Clear();
    ExibirTitulo("Mostrando avaliações");
    Console.Write("\nQual banda deseja consultar a avalição: ");
    string banda = Console.ReadLine()!;
    if (bandas.ContainsKey(banda)){
        List<int> notasBanda = bandas[banda];
        Console.WriteLine($"A média da banda {banda} é: {notasBanda.Average()}");
        VoltarAoMenu();
    }else{
        Console.WriteLine("Essa banda não foi encontrada");
        VoltarAoMenu();
    }
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota deseja avaliar a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeBanda].Add(nota);
        Console.WriteLine("\nNota registrada com sucesso");
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada");
        VoltarAoMenu();
    }
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostra todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir avaliação média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int numeroEscolhido = int.Parse(opcaoEscolhida);

    switch (numeroEscolhido)
    {
        case 1:
            RegistrarBanda(); break;
        case 2:
            MostrarBandas(); break;
        case 3:
            AvaliarBanda(); break;
        case 4:
            MostrarAvaliacao(); break;
        case 0:
            Console.WriteLine("0"); break;
        default:
            Console.WriteLine("Opção inválida"); break;
    }
}

ExibirMenu();