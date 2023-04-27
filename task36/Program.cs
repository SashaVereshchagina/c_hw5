// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [4];
FillArray(array);
PrintArray(array);

int sum = 0;
int i = 1;
int length = array.Length;

while (i < length)
{
    sum = sum + array[i];
    i = i + 2;
}

Console.WriteLine();
Console.WriteLine("Сумма нечетных элементов " + sum);

void FillArray (int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-100,100);
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