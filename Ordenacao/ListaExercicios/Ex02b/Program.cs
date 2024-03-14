using System.Diagnostics;

namespace Ex02;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[100];
        Random random = new Random();
        //Preenchendo o vetor com valores aleatórios
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(100);
        }
        //Imprimindo o vetor desordenado
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine("\n");

        //Ordenar o vetor com um recurso da linguagem
        Array.Sort(vetor);

        //Imprimindo o vetor ordenado
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}
