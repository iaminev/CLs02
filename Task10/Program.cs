/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int Get2ndDigit(int number)
{
    int digit2 = number / 10 % 10;
    return digit2;
}

System.Console.Write("Enter an integer between 100 and 999: ");
int getNumber = Convert.ToInt16(Console.ReadLine()!);
if (getNumber >= 100 && getNumber <= 999)
{
    int secondDigit = Get2ndDigit(getNumber);
    System.Console.WriteLine($"The second digit of {getNumber} is {secondDigit}");
}
else
{
    System.Console.WriteLine($"Cannot process entered value");
}
