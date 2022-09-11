//Задача 1 Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

int[] ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

myArray = ReverseArray(myArray);
ShowArray(myArray);
*/


//Работа в группах

//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//a < b + c, b < a + c, c < a + b
/*
bool Possible(int num1, int num2, int num3)
{
    if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1)
        return true;
    return false;    
} 

Console.WriteLine("Проверим возможен ли треугольник с вашими сторонами!");
Console.Write("Первая сторона треугольника равна: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая сторона треугольника равна: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третья сторона треугольника равна: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Возможен ли треугольник с вашими сторонами: {Possible(num1, num2, num3)}");
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: a и b.
//F(n) = F(n-1) + F(n-2)
/*
void Fibonacci(int a, int b, int n)
{
    Console.Write($"{a} {b} ");
    for (int  i = 0; i < n; i++)
    {
      int temp = a + b;
      a = b;
      b = temp;
      Console.Write($"{temp} ");  
    }
}

Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество аргументов: ");
int n = Convert.ToInt32(Console.ReadLine());
Fibonacci(a, b, n);
*/


//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string Binary(int num)
{
    string elem = string.Empty;
    while(num > 0)
    {
        int n = num % 2;
        elem = n + elem;
        num = num / 2;
    }
    return elem;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = Binary(num);
Console.WriteLine(result);
*/
