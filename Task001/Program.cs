// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.Write("Введите пятизначное число ");
string? number = Console.ReadLine();

void Palindrome (string num)
{
  if (num[0]==num[4] || num[1]==num[3]){
    Console.WriteLine($"Ваше число: {num} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {num} - не палиндром.");
}

if (number!.Length == 5)
{
    Palindrome (number);
}
else 
System.Console.WriteLine("Введите правильное число");
