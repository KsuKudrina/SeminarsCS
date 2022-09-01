//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSum(int num)
{
    int sum = 0;
    
    for(int current = 1; current <= num; current++ )
        sum = sum + current;
    return sum;
}

Console.Write("Input positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {a} = {FindSum(a)}");
*/

//Работа в группах
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
void Method(int arg)
{
    int kolvocifr = arg.ToString().Length;
    Console.WriteLine(kolvocifr);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Method(number);
*/
/*
int Method(int arg)
{
    int kolvocifr = arg.ToString().Length;
    return kolvocifr;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {number} = {Method(number)}");
*/
/*
int Method(int arg)
{
    int size = 0;
    while(arg > 0)
    {
        arg /= 10;
        size++;
    }
    return size;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {number} = {Method(number)}");
*/
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Method(int arg)
{
    int proiz = 1;

    for (int count = 1; count <= arg; count++)
    {
        proiz = count * proiz;
    }
    return proiz;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Произведение чисел от 1 до {number} = {Method(number)}");
*/


//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int newArray = new int[size];

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

ShowArray(CreateRandomArray(8,0,1));
*/