//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
//  1, -7, 567, 89, 223-> 3
/*
void QuantityNums()
{
    Console.Write("Количество запрашиваемых чисел: ");
    double q = Convert.ToInt32(Console.ReadLine());
    double count = 0;
    double i = 0;
    
    while(i < q)
    {
        if(i == q)
            break;
        else
        {
            Console.Write("Введите число: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if(num > 0)
                count++;
        }
        i++;       
    }
    Console.WriteLine(count);
}

QuantityNums();
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void PointIntersectionStraights (double b1, double k1, double b2, double k2)
{
    double x = 1;
    double y1 = 0;
    double y2 = 0;
    
    if (k1 != k2)
    {
        x = ((b2 - b1) / (k1 - k2));
        y1 = k1 * x + b1;//y1 = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        y2 = k2 * x + b2;//y2 = (k2 * (b2 - b1)) / (k1 - k2) + b2; 
        Console.WriteLine($"Точка пересечения двух прямых ({y1}; {y2})");
    }
    else
    Console.WriteLine($"Прямые параллельны");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

PointIntersectionStraights(b1, k1, b2, k2);
*/