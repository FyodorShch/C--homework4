/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.Clear();

int Pow(int p, int q)
{
    int result = p, i = 1;
    if (q == 0) return 1;
    while (i < q)
    {
        result = result * p;
        i++;
    }
    return result;
}

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
Pow(A, B);