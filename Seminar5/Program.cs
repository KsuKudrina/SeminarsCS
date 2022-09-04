/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();      
}

int FindPositiveSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum += array[i];
    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) sum += array[i];
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

int positiveSum = FindPositiveSum(myArray);
int negativeSum = FindNegativeSum(myArray);

Console.WriteLine($"Sum of positive elements is {positiveSum} \nSum of negative elements is {negativeSum}");
*/

//Работа в группе
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();      
}

int[] ChangeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * -1;
    return array;
}

int[] array1 = CreateRandomArray(25, -9, 9);
ShowArray(array1);
ShowArray(ChangeArray(array1));
*/

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();      
}

bool FindNumber(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == number) return true;
    return false;
} 

int[] array1 = CreateRandomArray(25, -9, 9);
ShowArray(array1);

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNumber(array1, num));
*/
//Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}   

int Amount(int[] array)
{
    int amount = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) amount++;
    }
   return amount; 
}

int[] array1 = CreateRandomArray(12, -100, 100);
ShowArray(array1);

Console.WriteLine(Amount(array1));
*/

//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] Method(int[] array)
{
    int[] newArray = new int[array.Length];
    if(array.Length % 2 == 0)
    {
        newArray = new int[array.Length/2];
    }
    else
    {
        newArray = new int[array.Length/2 + 1];
    }
    int count = 1;

    for(int i = 0; i <= array.Length/2; i++)
    {
        newArray[i] = array[i] * array[array.Length - count];
        count++;
    }
    return newArray;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int[] myArray2 = Method(myArray);
ShowArray(myArray2);
//Console.WriteLine($"The product of numbers is {Method(myArray)} ");
*/