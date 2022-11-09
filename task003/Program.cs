// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] array)
{
    int i = 0;
    int size = array.Length;
    while (i < size)
    {
        array[i] = new Random().NextDouble() * 10;
        i++;
    }
}

void PrintArray(double[] array)
{
    int i = 0;
    int size = array.Length;
    while (i < size)
    {
        Console.WriteLine(array[i]);
        i++;
    }
}

void MaxMinArray(double[] array)
{
    int size = array.Length;
    double max = array[0];
    double min = array[0];
    double result = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    result = max - min;
    Console.WriteLine($"Maximum  = {max}");
    Console.WriteLine($"Minimum  = {min}");
    Console.WriteLine($"The difference between the maximum and minimum values = {result}");
}

double[] array = new double[10];
FillArray(array);
PrintArray(array);
MaxMinArray(array);