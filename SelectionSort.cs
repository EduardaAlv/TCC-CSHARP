using System;
using System.Diagnostics;

public class SelectionSort
{
    void MetodoSelectionSort(int[] array)
    {
        int tamArray = array.Length;

        for (int i = 0; i < tamArray - 1; i++)
        {
            int elMinimo = i;
            for (int j = i + 1; j < tamArray; j++)
                if (array[j] < array[elMinimo])
                    elMinimo = j;

            int valor = array[elMinimo];
            array[elMinimo] = array[i];
            array[i] = valor;
        }
    }

    public static void Main()
    {
        string[] lines = File.ReadAllLines(
            "C:\\Users\\eduar\\Documents\\Repos\\ConsoleTeste\\ConsoleTeste\\dataDUZENTOSMIL.txt"
        );
        int[] numeros = new int[lines.Length];

        for (int i = 0; i < numeros.Length; i++)
        {
            if (int.TryParse(lines[i], out int numero))
            {
                numeros[i] = numero;
            }
        }

        double tempoDeExecucao = 0;
        SelectionSort selectionSort = new SelectionSort();
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        selectionSort.MetodoSelectionSort(numeros);

        stopwatch.Stop();

        tempoDeExecucao = stopwatch.ElapsedMilliseconds;

        Console.WriteLine(tempoDeExecucao);
    }
}
