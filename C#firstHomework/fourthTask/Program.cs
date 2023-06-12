// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
int sMax;
if (b>c) sMax= b;
else sMax = c;
if (sMax>max) {
    Console.WriteLine(sMax);
}
else Console.WriteLine(max);