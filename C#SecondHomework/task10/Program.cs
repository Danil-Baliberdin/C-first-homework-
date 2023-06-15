//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int secondDigit = number % 100 / 10;
    Console.WriteLine(secondDigit);
}
else Console.WriteLine("wrong number");