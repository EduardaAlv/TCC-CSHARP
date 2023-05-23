using System;
using System.Diagnostics;
class InsertionSort
{
    void MetodoInsertionSort(int[] array)
    {
        int tamArray = array.Length;
        for (int i = 1; i < tamArray; ++i)
        {
            int valorAtual = array[i];
            int posicao = i - 1;

            while (posicao >= 0 && array[posicao] > valorAtual)
            {
                array[posicao + 1] = array[posicao];
                posicao = posicao - 1;
            }
            array[posicao + 1] = valorAtual;
        }
    }

    public static void Main()
    {
        string[] lines = File.ReadAllLines(
            "C:\\Users\\eduar\\Documents\\Repos\\ConsoleTeste\\ConsoleTeste\\dataCINQUENTAMIL.txt"
        );
        int[] numeros = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            if (int.TryParse(lines[i], out int numero))
            {
                numeros[i] = numero;
            }
        }

        long tempoDeExecucao = 0;
        Stopwatch stopwatch = new Stopwatch();
        InsertionSort insertionSort = new InsertionSort();

        stopwatch.Start();

        insertionSort.MetodoInsertionSort(numeros);

        stopwatch.Stop();

        tempoDeExecucao = stopwatch.ElapsedMilliseconds;

        Console.WriteLine(tempoDeExecucao);
    }
}
