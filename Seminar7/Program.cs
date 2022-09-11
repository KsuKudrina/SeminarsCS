//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/

//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aij = i+j. 
//Выведите полученный массив на экран.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = i + j;   
        }
    }
    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(m, n);
Show2dArray(newArray);
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] SwitchQuad(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+= 2)
    {
        for(int j = 0; j < array.GetLength(1); j+= 2)
        {
            if(i % 2 == 0 && j % 2 == 0)
                array[i, j] = array[i,j] * array[i, j]; //array[i, j] = Math.Pow (array[i,j], 2);

        }
    }
    return array;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(newArray);
Console.WriteLine();
int[,] myArray = SwitchQuad(newArray);
Show2dArray(myArray);
*/

//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

    Console.WriteLine();
}

int FindSum(int[,] array)
{
    int sum = 0;

    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i,i];
       
    return sum;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(newArray);
Console.WriteLine();
int sum = FindSum(newArray);
Console.WriteLine($"Сумма элементов на главной диагонали = {sum}");
*/
