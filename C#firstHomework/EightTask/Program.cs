//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int a = Convert.ToInt32(Console.ReadLine());
int i = 2; 
while(i <= a)
{
    Console.WriteLine(i);
    i = i+2;
}