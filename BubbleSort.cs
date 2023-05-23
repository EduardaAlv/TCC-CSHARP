using System;
using System.Diagnostics;

public class BubbleSort
{
    void MetodoBubbleSort(int[] array)
    {
        int tamarrayay = array.Length;
        for (int i = 0; i < tamarrayay - 1; i++)
        {
            for (int j = 0; j < tamarrayay - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int valor = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = valor;
                }
            }
        }
    }

    public static void Main()
    {
        string[] lines = File.ReadAllLines(
            "C:\\Users\\eduar\\Documents\\Repos\\ConsoleTeste\\ConsoleTeste\\dataTRINTAMIL.txt"
        );
        int[] numeros = new int[lines.Length];

        for (int i = 0; i < numeros.Length; i++)
        {
            if (int.TryParse(lines[i], out int numero))
            {
                numeros[i] = numero;
            }
        }

        BubbleSort bubbleSort = new BubbleSort();
        double valoroDeExecucao = 0;
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        bubbleSort.MetodoBubbleSort(numeros);

        stopwatch.Stop();

        valoroDeExecucao = stopwatch.ElapsedMilliseconds;

        Console.WriteLine(valoroDeExecucao);
    }
}
