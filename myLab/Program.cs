// Коваленко Артём, 22-ИСП-2/2
// Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.

Console.Write("Введите длинну фигуры: ");
double var1 = double.Parse(Console.ReadLine());
Console.Write("Введите ширину фигуры: ");
double var2 = double.Parse(Console.ReadLine());
Console.Write("Введите высоту фигуры: ");
double var3 = double.Parse(Console.ReadLine());
double volume = var1 * var2 * var3;
double square = 2 * (var1 + var2 + var3);
Console.WriteLine($"Объём фигуры: {volume:F2}");
Console.Write($"Площадь фигуры: {square:F2}");