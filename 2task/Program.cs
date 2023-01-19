/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Clear();

int res(int N)
{
    int sum = 0;
    while (N != 0)
    {
        sum += N % 10;
        N /= 10;
    }
    return sum;
}

int A = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе равна {res(A)}");