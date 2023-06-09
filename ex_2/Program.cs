// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

void DotPeres(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b2-b1)/(k1-k2);
    array[1] = k1*array[0]+b1;
    foreach (var item in array)
    {
        System.Console.Write($"{item} ");
    }
 }

System.Console.WriteLine("Введите значение B1");
double B1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение K1");
double K1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение B2");
double B2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение K2");
double K2 = Convert.ToInt32(Console.ReadLine());
DotPeres(B1,K1,B2,K2);