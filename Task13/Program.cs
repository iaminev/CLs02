/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int Get3dDigitAsNumber(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    int result = number % 10;
    return result;
}

char Get3dDigitAsChar(int number)
{
    string NumberAsAtring = Convert.ToString(number);
    return NumberAsAtring[2];
}

System.Console.Write("Enter an integer: ");
int getNumber = Convert.ToInt32(Console.ReadLine()!);
if (getNumber >= 100)
{
    int thirdDigitAsNumber = Get3dDigitAsNumber(getNumber);
    System.Console.WriteLine($"The third digit of {getNumber} is {thirdDigitAsNumber} - found as number");
    char thirdDigitAsChar = Get3dDigitAsChar(getNumber);
    System.Console.WriteLine($"The third digit of {getNumber} is {thirdDigitAsChar} - found as char");
}
else
{
    System.Console.WriteLine($"There is no 3rd digit in {getNumber}");
}
