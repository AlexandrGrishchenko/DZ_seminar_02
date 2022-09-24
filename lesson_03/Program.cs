/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
Console.WriteLine("Введите цифрой день недели");
int userNumber = Convert.ToInt32(Console.ReadLine());
string[] DayWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (userNumber > 0 && userNumber < 6)  Console.Write($"{DayWeek[userNumber- 1]} является рабочим днем");
else if (userNumber > 5 && userNumber < 8)  Console.Write($"{DayWeek[userNumber- 1]} является выходным днем");
else Console.WriteLine("В неделе всего 7 дней");