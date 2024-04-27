
String nomeMercado = @"
█▀ █░█ █▀█ █▀▀ █▀█ █▀▄▀█ █▀▀ █▀▀ ▄▀█ █▀▄ █▀█   ▄▀█ ▀█▀ ▄▀█ █▀▀ ▄▀█ █▀▄ ▄▀█ █▀█ ░
▄█ █▄█ █▀▀ ██▄ █▀▄ █░▀░█ ██▄ █▄▄ █▀█ █▄▀ █▄█   █▀█ ░█░ █▀█ █▄▄ █▀█ █▄▀ █▀█ █▄█ ▄";


void ExibePlaca()
{
    Console.WriteLine(nomeMercado);
    Console.WriteLine("\nSejam Muitos bem vindos. Por favor escolha as opções desejadas:");

}
List<string> produtoList = new List<string> { /*"Arroz", "Feijão", "Macarrão", "Carne" */};
void Lista()
{
    Console.WriteLine("\nPRODUTOS NO CARRINHO: ");
    Console.WriteLine("Pressione qualquer tecla para sair");
    Console.WriteLine("");
    foreach (string produto in produtoList)
    {
        Console.WriteLine(produto);
    }
    Console.ReadKey();
    Console.Clear();
    MenuOpcoes();
}

void RemoveAlgoDaLista()
{
    Console.Clear();
    Console.Write("Digite o produto que deseja remover: ");
    string produtoRemovido = Console.ReadLine()!;
    produtoList.Remove(produtoRemovido);
    Console.WriteLine($"O produto {produtoRemovido} foi removido de sua lista ");
    Thread.Sleep(1000);
    MenuOpcoes();


}   

void MenuOpcoes()
{
    ExibePlaca();
    Console.WriteLine("\nDigite 1 para olhar estoque");
    Console.WriteLine("Digite 2 para registrar produto");
    Console.WriteLine("Digite 3 remover um produto de sua lista");
    Console.Write("\nDigite a apção desejada:");
    int opcaoDesejada = int.Parse(Console.ReadLine()!);


    switch (opcaoDesejada)
    {
        case 1: Lista();
            break;
        case 2: ResgistraProduto(); 
            break;
            case 3: RemoveAlgoDaLista();
            break;
        default: Console.WriteLine("\nOpção invalida");
            break;


    }
}

void ResgistraProduto()
{
    Console.Clear();
    Console.Write("Digite o produto desejado e aguarde para ser armazenado em seu carrinho: ");
    string produto = Console.ReadLine()!;
    produtoList.Add(produto);
    Console.WriteLine($"O produto {produto} foi registrado com sucesso.");
    Thread.Sleep(1000);
    Console.Clear();
    MenuOpcoes();
}

MenuOpcoes();


