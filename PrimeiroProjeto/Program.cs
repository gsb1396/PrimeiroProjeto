// Screen Sound

//Declaração de Variáveis
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound"; //Sempre começar variáveis no C# com início de letras minúsculas.

//Declaração de Funções
void ExibirMensagemDeBoasVindas() //Sempre começar funções no C# com início de Letras Maiúsculas.
{
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
"); //Quando se coloca o @ o nome que se dá a esse termo é VERBATIM LITERAL, é usado para quando você quer que o texto no código apareça exatamente como foi conebido. 
    
    Console.WriteLine(mensagemDeBoasVindas);
};

void ExibirOpcoesDoMenu()
{
    //Menu do Programa
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    //Entrada de Dados
    Console.Write("\nDigite a sua opção: "); //Deixando apenas o Write não se pula a linha, responde a entrada na mesma linha da pergunta.
    string opcaoEscolhida = Console.ReadLine()!;//Para que o readline NESSE CASO não retorne valor nulo coloca-se o ponto de ! EXCLAMAÇÂO ao lado.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    //Condições

    /*if (opcaoEscolhidaNumerica == 1) 
    {
        Console.WriteLine("Você digitou a opção número 1", opcaoEscolhida);
    }
    if (opcaoEscolhidaNumerica == 2)
    {
        Console.WriteLine("Você digitou a opção número 2", opcaoEscolhida);
    }
    if (opcaoEscolhidaNumerica == 3)
    {
        Console.WriteLine("Você digitou a opção número 3", opcaoEscolhida);
    }
    if (opcaoEscolhidaNumerica == 4)
    {
        Console.WriteLine("Você digitou a opção número 4", opcaoEscolhida);
    }
    if (opcaoEscolhidaNumerica == 0)
    {
        Console.WriteLine("Você saiu", opcaoEscolhida);
    }*/

    //OU Quando se usa vários condicionais que estão associados/relacionados usa-se o SWITCH

    switch (opcaoEscolhidaNumerica)
    {
        case 1: Console.WriteLine("Você escolheu a opção número 1", opcaoEscolhida);
                break;
        case 2: Console.WriteLine("Você escolheu a opção número 2", opcaoEscolhida);
                break;
        case 3: Console.WriteLine("Você escolheu a opção número 3", opcaoEscolhida);
                break;
        case 4: Console.WriteLine("Você escolheu a opção número 4", opcaoEscolhida);
                break;
        case 0: Console.WriteLine("Você escolheu a opção número 0", opcaoEscolhida);
                break;
        default: Console.WriteLine("OPÇÂO INVÁLIDA", opcaoEscolhida);
                break;
    }






};

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();


