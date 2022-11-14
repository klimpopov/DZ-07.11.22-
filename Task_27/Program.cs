// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNumber(int number)
    {
      int sum=0;
    for (int num = number; num>0; num=num/10)
    {
      sum=sum+num%10;
    }
      return sum;
    }
    Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumber(number);
Console.WriteLine($"Сумма чисел = {result}");
