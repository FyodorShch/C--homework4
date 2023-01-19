/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

Console.Clear();

void arr(int N, int start, int end)
{
    int[] RandArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandArray[i] = new Random().Next(start, end + 1);
    }
    Console.Write("[");
    for(int j=0;j<N;j++)
    {
        Console.Write($" {RandArray[j]}, ");
    }
    Console.Write("]");
}

int A = 8;
arr(A, 0, 100);