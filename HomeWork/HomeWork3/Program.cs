//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
void PalindromeNumber(int number)
{
   int current = 0;
   int num = number;
   
   while(num > 0)
    {        
        current = current * 10 + num % 10;
        num /= 10;
    }
    Console.WriteLine(current);
    if(current == number) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

PalindromeNumber(n);
*/


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53 
/*
double FindDistanse(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

Console.Write("Введите координаты первой точки (x Enter y Enter z): ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки (x Enter y Enter z): ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistanse(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Дистанция равна: {dist}");
*/


//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
void TableOfCubes(int num)
{
    int current = 1;
    int kub = 0;

    while(current <= num)
    {
        kub = current * current * current;
        current++;
        Console.Write(kub + " ");
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

TableOfCubes(n);
*/