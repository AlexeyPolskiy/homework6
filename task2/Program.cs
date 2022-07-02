// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Promt(string msg)
{
    System.Console.Write(msg);
    double numberInt = double.Parse(Console.ReadLine());
    return numberInt;
}

double b1 = Promt("Введите число b1 => ");
double k1 = Promt("Введите число k1 => ");
double b2 = Promt("Введите число b2 => ");
double k2 = Promt("Введите число k2 => ");

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
System.Console.WriteLine($"Точка пересечения двух прямых y = k1 * x + b1, y = k2 * x + b2 имеет координаты ({x:f1};{y:f1})");