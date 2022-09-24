/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
Console.WriteLine(" Введите число");

int determiningNumberDigits()
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 99) Console.Write($"Третьей цифры нет."); Console.WriteLine(" Введите число");
    return number;
}

int Y = determiningNumberDigits();


int getThirdNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    while (number > 999) number = number / 10;
    number = number % 10;
    return number;
}

int userNumber = getThirdNumber();
Console.WriteLine($"Третья цифра {userNumber}");