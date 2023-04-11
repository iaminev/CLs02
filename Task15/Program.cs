/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

bool ItIsHoliday(int number)
{
    bool result = false;
    if (number >= 1 && number <= 5)
    {
        result = false;
    }
    else
    {
        result = true;
    }
    return result;
}

System.Console.Write("Enter number of the day of the week: ");
int getNumber = Convert.ToInt32(Console.ReadLine()!);
if ((getNumber >= 1 && getNumber <= 7))
{
    bool itIsHoliday = ItIsHoliday(getNumber);
    System.Console.WriteLine($"The day of the week number {getNumber} is holiday: {itIsHoliday}");
}
else
{
    System.Console.WriteLine($"No such day pf the week!");
}
