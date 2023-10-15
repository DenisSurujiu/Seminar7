using System;

namespace C__7._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размероность массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размероность массива");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] array = new double[rows,columns]; 

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i,j] = new Random().Next(-10,10);
Console.Write(array[i,j]+ "\t");
}
Console.WriteLine();
}
        }
    }
}
