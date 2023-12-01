// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

Console.Clear();
int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
void InputArray(int[] array)
{
     for (int i = 0; i < 10; i++)
     {
         array[i] = new Random().Next(1, 101); 
     }
 }


 int evenNumbers(int[] array)
 {
     int count = 0;
     foreach (int el in array)
     {
         if (el % 2 == 0)
             count++;
     }
     return count;
 }


Console.WriteLine($"Результат: {evenNumbers(array)}");
 