// 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++) // array.Length = size
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int OddNumbersArray(int[] array)
{
     
     int sum = default;    
     for (int i = 0; i < array.Length; i++)
     if (i % 2!= 0)
     {
        sum = sum + array[i];
     }
    return sum;
}
int[] arr = CreateArrayRnd(5, 1, 10);
PrintArray(arr);
int oddNumbersArray = OddNumbersArray(arr);
Console.WriteLine($" -> {oddNumbersArray}");