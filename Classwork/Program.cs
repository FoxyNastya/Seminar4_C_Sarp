
/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
Решение:
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}

int GetSumm(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}

int number = GetNumber("Введите число больше 1");
int sum = GetSumm(number);
Console.WriteLine($"сумма чисел от 1 до {number} = {sum}");



_____________________________________________________________________
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return Math.Abs(result);
}



void GetLong(int GetNumber)
{
    string GetText = GetNumber.ToString();
    int longText = GetText.Length;
    Console.WriteLine(longText); 
}

int number = GetNumber("Введите любое число");
GetLong(number);
_______________________________________________________________________________________
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120


int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}
int MultipleNumers (int number)
{
    int multi = 1;
    for (int i = 1; i <= number; i++)
    {
        multi = multi * i;
    }
    return multi;
}

int number = GetNumber("Введите число: ");
int rezult = MultipleNumers(number);
Console.WriteLine(rezult);
___________________________________________________________________________________________________
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]

int [] CreateArray()
{
    int [] Array = new int [8];
    Random number = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = number.Next(0,2);
    }
   return Array;
}
int [] a = CreateArray();

void PrintArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
     Console.Write($" {array[i]} ");
   }
}
PrintArray(a);
______________________________________________________________________________________________________-
 */
