// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int [4];
FillArray(array);
PrintArray(array);

int k = 0;

for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] % 2 == 0) k = k + 1;
}

Console.WriteLine();
Console.WriteLine("Четных элементов " + k);

void FillArray (int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    
}

void PrintArray (int[] arr)

{
    int length = arr.Length;
    int count = 0;
    while (count < length-1)
    {
        Console.Write($"{arr[count]}, ");
        count++;
    }
    Console.Write($"{array[count]}");
}