// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Console.Write("Введите количество элементов массива: ");
Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);
int kol(int[] array)
{
    int i=0;
    int sum = 0;
    while (i < array.Length)
    {
       if(array[i]>0)
       sum = sum + 1;
       i = i + 1;
    }
    return sum;
}

Console.WriteLine($"\n Количество элементов больше нуля: {kol(array)}");

