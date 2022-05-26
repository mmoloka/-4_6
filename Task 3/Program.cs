/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

char [] Converting(int number)
{
    string remaindOfDivis = string.Empty;
    while(number >= 1)
    {
        int ost = number % 2;
        remaindOfDivis += ost.ToString();
        number = number / 2;

    }
    return remaindOfDivis.Reverse().ToArray();
}
void PrintArray(char[]arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write(arr[i]);
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
char [] str = Converting(num);
PrintArray(str);

