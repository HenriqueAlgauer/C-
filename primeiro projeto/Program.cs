string mensagem = "Boas vindas";

List<string> bandas = new List<string>();

void ExibirLogo(){
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
    Console.WriteLine(mensagem);
}

void RegistrarBanda(){
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine();
    bandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada.");
    Thread.Sleep(2000);
    Console.Clear();
    
    ExibirMenu();
}

void MostrarBandas(){
    Console.Clear();
    Console.WriteLine("Exibindo todas as bandas registradas =)");
    for(int i = 0; i < bandas.Count; i++){
        Console.WriteLine($"Banda: {bandas[i]}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ExibirMenu(){
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostra todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir avaliação média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int numeroEscolhido = int.Parse(opcaoEscolhida);
    
    switch(numeroEscolhido){
        case 1: 
            RegistrarBanda();break;
        case 2: 
            MostrarBandas();break;
        case 3: 
            Console.WriteLine("3");break;
        case 4: 
            Console.WriteLine("4");break;
        case 0: 
            Console.WriteLine("0");break;
        default: 
            Console.WriteLine("Opção inválida");break;
    }
}

ExibirLogo();
ExibirMenu();