// 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



int[] CreateArrayRnd(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
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
        if(i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int ArrayM (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > 0)
      {
        count++;
      }
    }
    return count;
 
}

Console.WriteLine("Введите количество чисел для проверки:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] arrayNumb = CreateArrayRnd(sizeArray, -1000, 1000);
PrintArray(arrayNumb);
int arrayM = ArrayM(arrayNumb);
Console.WriteLine($" -> {arrayM}");