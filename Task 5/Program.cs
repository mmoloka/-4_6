/*
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования
*/
int[] GetArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0 ; i < length ; i ++)
        array[i] = rnd.Next(0,15);
return array;
}

void PrintArray(int[] array)
{
    foreach(int num in array)
        Console.Write($"{num} ");
}

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for ( int i = 0 ; i < array.Length ; i ++)
        arrayCopy[i] = array[i];
return arrayCopy;
}
Console.WriteLine("Изначальный массив : ");
int[] array = GetArray(10);
PrintArray(array);
Console.WriteLine("\nКопия массива : ");
int[] arrayCopy = CopyArray(array);
PrintArray(arrayCopy);
