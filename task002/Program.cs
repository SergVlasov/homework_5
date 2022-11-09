// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0


void Fillarray(int[] array)
{
    int i = 0;
    int count = array.Length;
    while (i < array.Length)
    {
        array[i] = new Random().Next(1, 40);
        i++;
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    int count = array.Length;
    while (i < array.Length)
    {
        Console.WriteLine($"[{array[i]}]");
        i++;
    }

}


void SumElemArray(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for (int i = 1; i < size; i = i + 2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"Sum of elements in odd positions= {sum}");
}


int[] array = new int[7];
Fillarray(array);
PrintArray(array);
SumElemArray(array);