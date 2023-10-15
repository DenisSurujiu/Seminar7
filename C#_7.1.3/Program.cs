using System;

namespace C__7._1._3
{
    class Program
    {
        static void Main(string[] args)
        {

// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
Console.WriteLine("Введите размероность массива");
int n = Convert.ToInt32(Console.ReadLine());         //rows

Console.WriteLine("Введите размероность массива");
int m = Convert.ToInt32(Console.ReadLine());      //columns
int[,] array = new int[n,m];
FillArrayRandomNumbers(array);
PrintArray(array);
 for (int i = 0; i < array.GetLength(0); i++)
    {     
    double average= 0;   
     for (int j = 0; j < array.GetLength(1); j++)
    {
       average=(average+array[i,j]);
    }   
       average=average/m;
    Console.WriteLine(average);
    }



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-10, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

        }
    }
}
