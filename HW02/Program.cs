/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*
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


int GetSum(int number)
{
    int sum = 0;
    for (int i = 0; i <= numberA && i <= numberB; i++)
    {
        degree = Convert.ToInt32(Math.Pow(numberA, numberB));
    }
    return degree;
}
*/
Console.WriteLine("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
int a;
 while (num != 0)
 {
    a = num % 10;
    num = num / 10;
    sum = sum + a;
 }
  
  Console.WriteLine($"Сумма цифр числа : "+ sum);
  Console.ReadLine();

