//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
//   1 4 7 2
//   5 9 2 3
//   8 4 2 4
// В итоге получается вот такой массив:
//   7 4 2 1
//   9 5 3 2
//   8 4 4 2
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

void Sorting(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1) -1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }   
        }
    }    
    Console.WriteLine();    
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Sorting(myArray);
Show2dArray(myArray);
*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//   1 4 7 2
//   5 9 2 3
//   8 4 2 4
//   5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void MinSum(int[,] array)
{
    int current = 0;
    int sumMin = 0;
    int sum = 0;
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        sumMin += array[0, i]; 
        Console.WriteLine(array[i,i]);   
    }    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[i, j];   
        }
        
        if (sumMin > sum) 
        {
            sumMin = sum;
            current = i;
        }
        sum = 0;    
    }
    Console.WriteLine($"Строка с минимальной суммой: {current + 1}");    
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
MinSum(newArray);
*/


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//   2 4 | 3 4
//   3 2 | 3 3
//Результирующая матрица будет:
//   18 20
//   15 18
/*
int[,] CreateRandomMatrix()
{
    Console.WriteLine("Задайте размеры матрицы");
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] Matrix = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return Matrix; 
}

void ShowMatrix(int[,] matrix1, int[,] matrix2)
{
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write(matrix1[i, j] + " ");
        }
        Console.Write("| | ");
        
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write(matrix2[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixC(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if(matrix1.GetLength(0) == matrix2.GetLength(1))
    {
        for(int i = 0; i < matrix1.GetLength(0); i++)
            for(int j = 0; j < matrix2.GetLength(1); j++)
            {
                for(int k = 0; k < matrix2.GetLength(0); k++)
                {
                    newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
           
    }
    else
    {
        Console.WriteLine("Перемножение матриц невозможно ");
    } 
    return newMatrix; 
}

void ShowNewMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixA = CreateRandomMatrix();
int[,] MatrixB = CreateRandomMatrix();
ShowMatrix((MatrixA),(MatrixB));
int[,] newMatrix = MatrixC(MatrixA, MatrixB);
ShowNewMatrix(newMatrix);
*/


//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//   66(0,0,0) 25(0,1,0)
//   34(1,0,0) 41(1,1,0)
//   27(0,0,1) 90(0,1,1)
//   26(1,0,1) 55(1,1,1)
/*
int[,,] CreateRandom3dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of layers: ");
    int layers = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    int[,,] new3dArray = new int[rows, layers, columns];
     
    bool available;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < layers; )                                                                            
            {
                available = false;
                int num = new Random().Next(10, 100);
                
                if(num >= 10)
                {
                    for (int m = 0; m < rows; m++)
                    {                        
                        for (int n = 0; n < columns; n++)
                        {
                            for (int l = 0; l < layers; l++)
                            {
                                if(new3dArray[m, n, l] == num)
                                {                                   
                                    available = true;
                                    break;
                                } 
                            }    
                        }                    
                    }                       
                    if(available == false)
                    {
                        new3dArray[i, j, k] = num;
                        k++;
                    }
                }     
            }
        }
    }
    return new3dArray;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[, ,] new3dArray = CreateRandom3dArray();
Show3dArray(new3dArray);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//   01 02 03 04
//   12 13 14 05
//   11 16 15 06
//   10 09 08 07

int[,] CreateRandom2dArray()
{
    //Console.Write("Input number of rows: ");
    //int rows = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Input number of colums: ");
    //int columns = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Input the min possible value: ");
    //int minValue = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Input the max possible value: ");
    //int maxValue = Convert.ToInt32(Console.ReadLine());

    int size = 4;
    int num = 01;
    int[,] newArray = new int[size, size];
    int i;
    int j;

    //for(i = 0; i < size; i++)
    //{
        for(j = 0, i = 0; j < size; j++, i++) 
        {
            newArray[i,j] = num;
            num++;
            //Console.Write(num + " * ");   
        }
            
            for(i = 1, j = size -1; i < size; i++)
            {
                newArray[i, j] = num;
                num++; 
            }
                
                for(j = size - 2, i = size -1; j >= 0; j--)
                {                        
                    newArray[i, j] = num;
                    num++; 
                }
                    
                    for(i = size - 2, j = 0; i > 0; i--)
                    {
                        newArray[i, j] = num;
                        num++;
                         
                    }
                    size--;
                            
    //}
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