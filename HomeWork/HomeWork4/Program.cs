//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
int DegreeOfNumber(int numA, int numB)
{
    int current = numA;
    
    for(int count = 2; count <= numB; count++)
    {
        current *= numA; 
    }
    return current;
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} в натуральной степени числа {b} = {DegreeOfNumber(a, b)}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
void MethodSum (int num)
{
    int n = 0;
    int sum = 0;
    while(num > 0)
    {
        n = num % 10;
        num /= 10;
        sum += n; 
    }
    Console.WriteLine("Сумма  цифр в числе = " + sum);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

MethodSum(number);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
 
/*
int[] CreateArray (int size) 
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    return newArray;   
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();      
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Заполните массив: ");

int[] myArray = CreateArray(size);
ShowArray(myArray);
*/