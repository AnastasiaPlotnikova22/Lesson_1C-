// 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



int[] CreateArrayRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число[{i}] = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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
    int resalt = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > 0)
      {
        resalt++;
      }
    }
    return resalt;
 
}

Console.WriteLine("Введите количество чисел для проверки:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа для проверки:");
int[] arrayNumb = CreateArrayRnd(sizeArray);
PrintArray(arrayNumb);
int arrayM = ArrayM(arrayNumb);
Console.WriteLine($" -> {arrayM}");