// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

float [] array = new float [5];
FillArray(array);
PrintArray(array);
SelectionSort(array);

float result = array[array.Length - 1] - array[0];
Console.WriteLine("Разница между максимумом и минимумом = " + result);

void SelectionSort (float[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
        if (array[j] < array[minPosition]) minPosition = j;
        }
        float temporary = array[i];
        array[i] = array [minPosition];
        array[minPosition] = temporary;
    }
}   

void FillArray (float[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
    
}

void PrintArray (float[] arr)

{
    int length = arr.Length;
    int count = 0;
    while (count < length-1)
    {
        Console.Write($"{arr[count]}, ");
        count++;
    }
    Console.Write($"{array[count]}");
    Console.WriteLine();
}