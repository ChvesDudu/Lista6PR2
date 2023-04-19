using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1

            {
                int quantidadeTotal = 0;
                double precoTotal = 0;

                while (true)
                {
                    Console.WriteLine("Digite a quantidade de itens do produto (digite 0 ou um número negativo para encerrar): ");
                    int quantidade = int.Parse(Console.ReadLine());

                    if (quantidade <= 0)
                    {
                        break;
                    }

                    Console.WriteLine("Digite o preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());

                    quantidadeTotal += quantidade;
                    precoTotal += quantidade * preco;
                }

                Console.WriteLine("Total de itens adquiridos: " + quantidadeTotal);
                Console.WriteLine("Valor total da compra: R$" + precoTotal.ToString("F2"));
                Console.ReadLine();

            }

            //Exercicio2

            {
                {
                    string nomeProdutoMaiorInvestimento = "";
                    double maiorInvestimento = 0;
                    string nomeProdutoMenorInvestimento = "";
                    double menorInvestimento = double.MaxValue;

                    while (true)
                    {
                        Console.WriteLine("Digite o nome do produto (digite 'fim' para encerrar): ");
                        string nomeProduto = Console.ReadLine();

                        if (nomeProduto.ToLower() == "fim")
                        {
                            break;
                        }

                        Console.WriteLine("Digite o número de itens do produto: ");
                        int numeroItens = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o preço de compra do produto: ");
                        double precoCompra = double.Parse(Console.ReadLine());

                        double investimentoProduto = numeroItens * precoCompra;

                        if (investimentoProduto > maiorInvestimento)
                        {
                            maiorInvestimento = investimentoProduto;
                            nomeProdutoMaiorInvestimento = nomeProduto;
                        }

                        if (investimentoProduto < menorInvestimento)
                        {
                            menorInvestimento = investimentoProduto;
                            nomeProdutoMenorInvestimento = nomeProduto;
                        }
                    }

                    Console.WriteLine("Maior investimento: " + nomeProdutoMaiorInvestimento + " - R$" + maiorInvestimento.ToString("F2"));
                    Console.WriteLine("Menor investimento: " + nomeProdutoMenorInvestimento + " - R$" + menorInvestimento.ToString("F2"));
                    Console.ReadLine();
                }
            }

            //Execicio3

            {
                {
                    int numAvaliacoes;
                    float somaPesos = 0;

                    Console.Write("Digite o número de avaliações: ");
                    numAvaliacoes = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= numAvaliacoes; i++)
                    {
                        Console.Write($"Digite o peso da avaliação {i}: ");
                        float peso = float.Parse(Console.ReadLine());
                        somaPesos += peso;
                    }

                    if (somaPesos < 100)
                    {
                        Console.WriteLine($"Soma total dos pesos é insuficiente: {somaPesos}%");
                    }
                    else if (somaPesos > 100)
                    {
                        Console.WriteLine($"Soma total dos pesos é excedente: {somaPesos}%");
                    }
                    else
                    {
                        Console.WriteLine($"Soma total dos pesos é adequada: {somaPesos}%");
                    }
                }
            }

            //Exercicio4
            {
                Console.Write("Digite a sigla do estado: ");
                string sigla = Console.ReadLine().ToUpper();

                switch (sigla)
                {
                    case "AC":
                        Console.WriteLine("Acre");
                        break;
                    case "AL":
                        Console.WriteLine("Alagoas");
                        break;
                    case "AP":
                        Console.WriteLine("Amapá");
                        break;
                    case "AM":
                        Console.WriteLine("Amazonas");
                        break;
                    case "BA":
                        Console.WriteLine("Bahia");
                        break;
                    case "CE":
                        Console.WriteLine("Ceará");
                        break;
                    case "DF":
                        Console.WriteLine("Distrito Federal");
                        break;
                    case "ES":
                        Console.WriteLine("Espírito Santo");
                        break;
                    case "GO":
                        Console.WriteLine("Goiás");
                        break;
                    case "MA":
                        Console.WriteLine("Maranhão");
                        break;
                    case "MT":
                        Console.WriteLine("Mato Grosso");
                        break;
                    case "MS":
                        Console.WriteLine("Mato Grosso do Sul");
                        break;
                    case "MG":
                        Console.WriteLine("Minas Gerais");
                        break;
                    case "PA":
                        Console.WriteLine("Pará");
                        break;
                    case "PB":
                        Console.WriteLine("Paraíba");
                        break;
                    case "PR":
                        Console.WriteLine("Paraná");
                        break;
                    case "PE":
                        Console.WriteLine("Pernambuco");
                        break;
                    case "PI":
                        Console.WriteLine("Piauí");
                        break;
                    case "RJ":
                        Console.WriteLine("Rio de Janeiro");
                        break;
                    case "RN":
                        Console.WriteLine("Rio Grande do Norte");
                        break;
                    case "RS":
                        Console.WriteLine("Rio Grande do Sul");
                        break;
                    case "RO":
                        Console.WriteLine("Rondônia");
                        break;
                    case "RR":
                        Console.WriteLine("Roraima");
                        break;
                    case "SC":
                        Console.WriteLine("Santa Catarina");
                        break;
                    case "SP":
                        Console.WriteLine("São Paulo");
                        break;
                    case "SE":
                        Console.WriteLine("Sergipe");
                        break;
                    case "TO":
                        Console.WriteLine("Tocantins");
                        break;
                    default:
                        Console.WriteLine("Sigla de estado inválida.");
                        break;
                }
            }

            //Exercicio5

            
                {
                    Console.Write("Digite o número do mês (1 a 12): ");
                    int mes = int.Parse(Console.ReadLine());

                    switch (mes)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("Inverno");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("Primavera");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Verão");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("Outono");
                            break;
                        default:
                            Console.WriteLine("Mês inválido.");
                            break;
                    }

                    // Verificar se o mês informado é de transição entre duas estações
                    if ((mes == 3 && mes == 4) || (mes == 9 && mes == 10))
                    {
                        Console.Write("O mês informado é de transição entre duas estações. Deseja exibir a estação anterior ou posterior? (A/P): ");
                        string opcao = Console.ReadLine().ToUpper();

                        switch (opcao)
                        {
                            case "A":
                                Console.WriteLine("Estação anterior: " + (mes == 3 ? "Inverno" : "Verão"));
                                break;
                            case "P":
                                Console.WriteLine("Próxima estação: " + (mes == 3 ? "Primavera" : "Outono"));
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
                    }
                }
            

            //Exercicio6

            {
                {
                    Console.Write("Digite o seu peso (em kg): ");
                    double peso = double.Parse(Console.ReadLine());

                    Console.Write("Digite a sua altura (em metros): ");
                    double altura = double.Parse(Console.ReadLine());

                    double imc = peso / (altura * altura);

                    Console.Write("Seu IMC é: " + imc.ToString("F2") + ". Você está ");
                    if (imc < 18.5)
                    {
                        Console.WriteLine("abaixo do peso.");
                    }
                    else if (imc < 25)
                    {
                        Console.WriteLine("com o peso normal.");
                    }
                    else if (imc < 30)
                    {
                        Console.WriteLine("com sobrepeso.");
                    }
                    else if (imc < 35)
                    {
                        Console.WriteLine("com obesidade grau 1.");
                    }
                    else if (imc < 40)
                    {
                        Console.WriteLine("com obesidade grau 2.");
                    }
                    else
                    {
                        Console.WriteLine("com obesidade grau 3 (mórbida).");
                    }
                }
            }

            //Exercicio7

            {
                {
                    Console.Write("Digite um número inteiro positivo: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.Write("Divisores de " + n + ": ");
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
