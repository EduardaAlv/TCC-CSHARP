using System;
using System.Diagnostics;

class ShellSort
{
    void MetodoShellSort(int[] array)
    {
        int tamArray = array.Length;
        for (int lacuna = tamArray / 2; lacuna > 0; lacuna /= 2)
        {
            for (int i = lacuna; i < tamArray; i += 1)
            {
                int valor = array[i];
                int j;
                for (j = i; j >= lacuna && array[j - lacuna] > valor; j -= lacuna)
                    array[j] = array[j - lacuna];

                array[j] = valor;
            }
        }
    }

    public static void Main()
    {
        string[] lines = File.ReadAllLines(
            "C:\\Users\\eduar\\Documents\\Repos\\ConsoleTeste\\ConsoleTeste\\dataDEZMILHOES.txt"
        );
        int[] numeros = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            if (int.TryParse(lines[i], out int numero))
            {
                numeros[i] = numero;
            }
        }
        ShellSort shellSort = new ShellSort();

        double tempoDeExecucao = 0;
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        shellSort.MetodoShellSort(numeros);

        stopwatch.Stop();

        tempoDeExecucao = stopwatch.ElapsedMilliseconds;

        Console.WriteLine(tempoDeExecucao);
    }
}
