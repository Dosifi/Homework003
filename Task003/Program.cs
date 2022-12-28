// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    int cube = Convert.ToInt32(Math.Pow(i, 3));
    System.Console.Write($"{cube} ");
}