using Atividade;
using System.Security.AccessControl;

//Atividade 1
//Console.WriteLine("-------------------------------Atividade 1-------------------------------");
//Console.WriteLine("Digite uma quantidade mínima");
//int quant_min = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite uma quantidade máxima");
//int quant_max = int.Parse(Console.ReadLine());

//int estoque = (quant_min + quant_max) / 2;
//Console.WriteLine($"Estoque : {estoque}");
//Console.WriteLine("-------------------------------------------------------------------------");


////Atividade 2
//Console.WriteLine("-------------------------------Atividade 2-------------------------------");
//int acao = -1;
//Console.WriteLine("Digite um valor em dolar");
//double valor_dolar = double.Parse(Console.ReadLine());

//while (acao < 1 || acao > 2)
//{
//    Console.WriteLine("Deseja saber qual e esse valor em reais?");
//    Console.WriteLine("1 - Sim" +
//                      "\n2 - Não");
//    acao = int.Parse(Console.ReadLine());
//    if (acao == 1)
//    {
//        //Valor real do dolar 
//        double V_dolar = 5.50;
//        double resultado = valor_dolar * V_dolar;
//        Console.WriteLine($"Valor: {resultado}");
//    }
//    else 
//    {
//        Console.WriteLine("Ação invalida");
//        Console.WriteLine("Digite uma ação valida");
//    }
//}
//Console.WriteLine("-------------------------------------------------------------------------");

////Atividade 3 

//Console.WriteLine("-------------------------------Atividade 3-------------------------------");

//int acaosolicitada = -1;


//Console.WriteLine("Qual o nome do vendedor?");
//string Nome_Vendedor = Console.ReadLine();

//Console.WriteLine("Qual o codico da peça?");
//string cod_peca = Console.ReadLine();

//Console.WriteLine("Qual Valor da peça?");
//double valor_peca = double.Parse(Console.ReadLine());

//Console.WriteLine("Quantidade de peças vendidas?");
//int quant_vendida = int.Parse(Console.ReadLine());



//while (acaosolicitada < 1 || acaosolicitada > 2)
//{

//    Console.WriteLine("Deseja saber qual e sua comição?");
//    Console.WriteLine("1 - sim" +
//                      "\n2 - não");
//    acaosolicitada = int.Parse(Console.ReadLine());
//    if (acaosolicitada == 1)
//    {
//        comissao c = new comissao(quant_vendida, valor_peca, Nome_Vendedor);
//        c.Soma_Comissao();
//    }
//    else 
//    {
//        Console.WriteLine("Ação invalida");
//        Console.WriteLine("Digite uma ação valida");
//    }
//}
//Console.WriteLine("-------------------------------------------------------------------------");

////Atividade 4
//Console.WriteLine("-------------------------------Atividade 4-------------------------------");

//int opicao = -1;
//Console.WriteLine("Digite um Valor A Inteiro");
//double A = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite Um valor B Inteiro");
//double B = double.Parse(Console.ReadLine());


//while (opicao < 1 || opicao > 3)
//{
//    Console.WriteLine($"1 - Ver Valor de A p/ B" +
//                  $"\n2 - Ver Valor de B p/ A" +
//                  $"\n3 - Sair ");
//    opicao= int.Parse(Console.ReadLine());
//    if (opicao == 1)
//    {
//        A = B;
//        Console.WriteLine($"Valor de A para B {A}");
//    }
//    else if (opicao == 2)
//    {
//        B = A;
//        Console.WriteLine($"Valor de B para A {B}");
//    }
//    else
//    {
//        Console.WriteLine($"Opição invalida !!!!" +
//                         $"\nEscolha uma opição valida");
//    }
//}
//Console.WriteLine("-------------------------------------------------------------------------");

////Atividade 5

//Console.WriteLine("-------------------------------Atividade 5-------------------------------");
//Console.WriteLine("-------------------------------------------------------------------------");

////Atividade 6
//Console.WriteLine("-------------------------------Atividade 6-------------------------------");

//int num1 = 0;
//int num2 = 0;
//int acaoselecionada = -1;


//    Console.WriteLine("Digite um número");
//    num1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Digite um segundo número");
//    num2 = int.Parse(Console.ReadLine());

//while (acaoselecionada < 1 || acaoselecionada > 4)
//{
//    Console.WriteLine($"1 - Adição" +
//                      $"\n2 - Subitração" +
//                      $"\n3 - Multiplicação" +
//                      $"\n4 - Divisão");
//    Console.WriteLine("Qual ação deseja realizar ");
//    acaoselecionada= int.Parse(Console.ReadLine());

//    if(acaoselecionada == 1)
//    {
//        int resposta = num1 + num2;
//        Console.WriteLine($"O resultado e {resposta}");
//    }
//    else if (acaoselecionada == 2)
//    {
//        int resposta = num1 - num2;
//        Console.WriteLine($"O resultado e {resposta}");
//    }
//    else if(acaoselecionada==3)
//    {
//        int resposta = num1 * num2;
//        Console.WriteLine($"O resultado e {resposta}");
//    }
//    else if (acaoselecionada == 4)
//    {
//        int resposta = num1 / num2;
//        Console.WriteLine($"O resultado e {resposta}");
//    }
//    else
//    {
//        Console.WriteLine("Opição invalida !!!!!!!!!!!!!!!!!!!!!!!!!!!" +
//                          "\nEscolha uma opição valida");
//    }
//}

//Console.WriteLine("-------------------------------------------------------------------------");


//Atividade 7
Console.WriteLine("-------------------------------Atividade 7-------------------------------");
int numero1 = 0;
int numero2 = 0;
int opicaoselecionada = -1;

Console.WriteLine("Digite um número");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um segundo número");
numero2 = int.Parse(Console.ReadLine());

while (opicaoselecionada < 1 || opicaoselecionada > 4)
{
    Console.WriteLine($"1 - Ver se os números saõ multiplos um do outro" +
                      $"\n2 - Ver se os dois numeros são pares" +
                      $"\n3 - Ver se a média dos dois números e Maior ou Igual a 7" +
                      $"\n4 - Sair");
    Console.WriteLine("Qual ação deseja realizar ");
    opicaoselecionada = int.Parse(Console.ReadLine());

    if (opicaoselecionada == 1)
    {
       
    }
    else if (opicaoselecionada == 2)
    {
       
    }
    else if (opicaoselecionada == 3)
    {
       
    }
    else if(opicaoselecionada == 4)
    {

    }
    else
    {
        Console.WriteLine("Opição invalida !!!!!!!!!!!!!!!!!!!!!!!!!!!" +
                          "\nEscolha uma opição valida");
    }
}


Console.WriteLine("-------------------------------------------------------------------------");