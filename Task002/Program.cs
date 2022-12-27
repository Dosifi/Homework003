// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

System.Console.Write("Введите координату x точки А ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y точки А ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z точки А ");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату x точки B ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y точки B ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z точки B ");
int z2 = Convert.ToInt32(Console.ReadLine());

double segment_length = Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)),2);

Console.WriteLine($"Длина отрезка  {segment_length}");
