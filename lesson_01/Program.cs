/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"Вторым цифрой числа {userNumber} является {userNumber / 10 % 10}");
