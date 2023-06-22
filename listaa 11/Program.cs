using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaa_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Exercício 1");
            Console.WriteLine("2. Exercício 2");
            Console.WriteLine("3. Exercício 3");
            Console.WriteLine("4. Exercício 4");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());



            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
           

            }



            Console.WriteLine();
        } while (opcao != 4);
        }



       public static void // Código do exercício 1
        {
        
        Console.WriteLine ( "1000" );
        int tamanho = int.Parse(Console.ReadLine());

    int[] numeros = new int[tamanho];

    Random gerador = new Random();
        
        for  (int indice = 0; indice<tamanho; indice ++)
        {
             numeros[indice] = gerador.Next(10, 20);
        }
        bool naoAchei = true;

       Console.WriteLine("Digite o número a procurar: ");
       int procurar = int.Parse(Console.ReadLine());


       for (int indice = 0; indice < tamanho; indice++)
       {
            if (numeros[indice] == procurar)
            {
•              Console.WriteLine("Achei na posição " + indice);
               naoAchei = false;
            }
        } 

     }while (naoAchei) ;



Console.WriteLine { get; }
}



    static void Exercicio2()
    {
    // Código do exercício 2
    int[] numeros = new int[20000];

    // Preenche o vetor com números inteiros
    PreencherVetor(numeros);

    // Solicita ao usuário o número a ser pesquisado
    Console.Write("Digite um número para pesquisar: ");
    int numeroPesquisado = Convert.ToInt32(Console.ReadLine());

    // Conta a ocorrência do número pesquisado no vetor
    int ocorrencias = ContarOcorrencias(numeros, numeroPesquisado);

    Console.WriteLine($"O número {numeroPesquisado} ocorre {ocorrencias} vezes no vetor.");
}

static void PreencherVetor(int[] vetor)
{
    Random random = new Random();

    for (int i = 0; i < vetor.Length; i++)
    {
        vetor[i] = random.Next(1, 101); // Preenche o vetor com números aleatórios de 1 a 100
    }
}

static int ContarOcorrencias(int[] vetor, int numero)
{
    int contador = 0;

    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] == numero)
        {
            contador++;
        }
    }

    return contador;
}
}



        Console.WriteLine("Executando o exercício 2...");
    }



    static void Exercicio3()
    {
    int[] vetor = new int[10];
    int[] segundoVetor = new int[10];

    // Preenche o vetor com valores informados pelo usuário
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Digite o valor {i + 1}: ");
        vetor[i] = Convert.ToInt32(Console.ReadLine());
    }

    // Cria o segundo vetor com base nas regras especificadas
    for (int i = 0; i < 10; i++)
    {
        if (i % 2 == 0)
        {
            segundoVetor[i] = vetor[i] / 2;
        }
        else
        {
            segundoVetor[i] = vetor[i] * 3;
        }
    }

    // Imprime os dois vetores
    Console.WriteLine("Vetor original:");
    ImprimirVetor(vetor);

    Console.WriteLine("Segundo vetor:");
    ImprimirVetor(segundoVetor);
}

static void ImprimirVetor(int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"Índice {i}: {vetor[i]}");



        Console.WriteLine("Executando o exercício 3...");
        }
    }
    static void Exercicio4()
    {
    // Código do exercício 4

    int[] vetor = new int[5000];

    // Preenche o vetor com os valores informados pelo usuário
    for (int i = 0; i < 5000; i++)
    {
        Console.Write($"Digite o valor {i + 1}: ");
        vetor[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Números primos encontrados:");

    // Verifica quais números são primos e os imprime na tela
    for (int i = 0; i < 5000; i++)
    {
        if (EhPrimo(vetor[i]))
        {
            Console.WriteLine(vetor[i]);
        }
    }
}

static bool EhPrimo(int numero)
{
    if (numero < 2)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0)
        {
            return false;
        }
    }

    return true;
}
}



        Console.WriteLine("Executando o exercício 4...");




    }
    }
}
