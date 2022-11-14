// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int MathPow(int a, int b)
{
    int result = a;
    for (int i = 2; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.Write("Введите число А = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = ");
int b = Convert.ToInt32(Console.ReadLine());
int result = MathPow(a, b);
Console.WriteLine($"Число {a} в степени {b} = {result}");