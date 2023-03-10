/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/



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

int GetDegree(int numberA, int numberB)
{
    int degree = 0;
    for (int i = 0; i <= numberA && i <= numberB; i++)
    {
        degree = Convert.ToInt32(Math.Pow(numberA, numberB));
    }
    return degree;
}

int numberA = GetNumber("Введите число больше 1");
int numberB = GetNumber("Введите число больше 1");
int degree = GetDegree(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {degree}");