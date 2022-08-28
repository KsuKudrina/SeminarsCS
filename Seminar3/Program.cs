//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FintQuart(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input X coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FintQuart(xA, yA);
Console.WriteLine("Num of quad is " + quadrant);
*/


//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void CoordinateRange(int num)
{
    if(num == 1) 
    {
        Console.WriteLine($"Диапазон возможных координат точек в четверти {num}: x > 0, y > 0");
    }
    if(num == 2)
    {
        Console.WriteLine($"Диапазон возможных координат точек в четверти {num}: x < 0, y > 0");
    }
    if(num == 3)
    {
        Console.WriteLine($"Диапазон возможных координат точек в четверти {num}: x < 0, y < 0");
    }
    if(num == 4)
    {
        Console.WriteLine($"Диапазон возможных координат точек в четверти {num}: x > 0, y < 0");
    }
    if(num > 4 || num < 0) Console.WriteLine("Четверти с таким номером не существует");
    
}

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

CoordinateRange(quarter);
*/


//Напишите программу, которая принимает на вход число (n) и выдаёт квадраты чисел от 1 до n.
/*
void SquaresNumbers(int num)
{
    int current = 1;
    int quad = 0;
    while(current <= num)
    {
        quad = current * current;
        Console.Write(quad + " ");
        current++;
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Квадраты чисел от 1 до {n}: ");
SquaresNumbers(n);
*/


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double FindDistanse(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

Console.Write("Введите координаты первой точки (x - enter - y): ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки (x - enter - y): ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistanse(xA, yA, xB, yB);
Console.WriteLine($"Дистанция равна: {dist}");
*/
