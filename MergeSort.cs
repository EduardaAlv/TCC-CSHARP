using System;
using System.Diagnostics;

public class MergeSort
{
    void merge(int[] array, int indiceInicio, int meio, int indiceFinal)
    {
        int array1 = meio - indiceInicio + 1;
        int array2 = indiceFinal - meio;

        int[] X = new int[array1];
        int[] Y = new int[array2];
        int i,
            j;

        for (i = 0; i < array1; ++i)
            X[i] = array[indiceInicio + i];
        for (j = 0; j < array2; ++j)
            Y[j] = array[meio + 1 + j];

        i = 0;
        j = 0;

        int indiceInicialSubArray = indiceInicio;
        while (i < array1 && j < array2)
        {
            if (X[i] <= Y[j])
            {
                array[indiceInicialSubArray] = X[i];
                i++;
            }
            else
            {
                array[indiceInicialSubArray] = Y[j];
                j++;
            }
            indiceInicialSubArray++;
        }

        while (i < array1)
        {
            array[indiceInicialSubArray] = X[i];
            i++;
            indiceInicialSubArray++;
        }

        while (j < array2)
        {
            array[indiceInicialSubArray] = Y[j];
            j++;
            indiceInicialSubArray++;
        }
    }

    void MetodoMergeSort(int[] array, int indiceInicio, int indiceFinal)
    {
        if (indiceInicio < indiceFinal)
        {
            int meio = indiceInicio + (indiceFinal - indiceInicio) / 2;

            MetodoMergeSort(array, indiceInicio, meio);
            MetodoMergeSort(array, meio + 1, indiceFinal);

            merge(array, indiceInicio, meio, indiceFinal);
        }
    }

    public static void Main()
    {
        string[] lines = File.ReadAllLines(
            "C:\\Users\\eduar\\Documents\\Repos\\ConsoleTeste\\ConsoleTeste\\dataTRINTAMILHOES.txt"
        );
        int[] numeros = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            if (int.TryParse(lines[i], out int numero))
            {
                numeros[i] = numero;
            }
        }
        MergeSort mergeSort = new MergeSort();

        double tempoDeExecucao = 0;
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        mergeSort.MetodoMergeSort(numeros, 0, numeros.Length - 1);

        stopwatch.Stop();

        tempoDeExecucao = stopwatch.ElapsedMilliseconds;

        Console.WriteLine(tempoDeExecucao);
    }
}
