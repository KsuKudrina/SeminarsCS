// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int quantity = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            quantity++;
    }
    return quantity;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible positive three-digit value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible positive three-digit value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.WriteLine($"Number of even numbers is {EvenNumbers(myArray)}");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//  [3, 7, 23, 12] -> 19
//  [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int MethodSum (int[] array)
{
    int sum = 0;
    
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }    
    return sum;
}    

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.WriteLine($"Sum of elements in odd positions is {MethodSum(myArray)}");
*/


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
//  [3 7 22 2 78] -> 76
/*
double[] CreateRandomArray (int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    return newArray;
}

void ShowArray (double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double NumberMax(double[] array)
{
    double max = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
    }
    return max;
}

double NumberMin(double[] array)
{    
    int i = 0;
    double min = array[i];
    
    while(i < array.Length)
    {
        if(array[i] < min)
            min = array[i];
        i++;
    }
    return min;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

double MaxNum = NumberMax(myArray);
double MinNum = NumberMin(myArray);
Console.WriteLine($"Max numbers: {MaxNum}");
Console.WriteLine($"Min numbers: {MinNum}");

Console.WriteLine($"Difference between  maximum and minimum element is {MaxNum - MinNum}");
*/