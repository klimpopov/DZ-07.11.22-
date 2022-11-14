// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] InMassive (int size, int min, int max)
                   {
      int[] array=new int[size];
                    for (int i=0; i < size; i++)
                    {
 array[i]=new Random().Next(min, max); 
                    }
return array;

                   }
Console.Write("Введите размер массива = "); 
   int size = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите минимальный элемент массива = "); 
   int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный элемент массива = "); 
   int max = Convert.ToInt32(Console.ReadLine());
    int[] array= InMassive(size, min, max);
    Console.WriteLine($"[{String.Join(", ", array)}]");
