/*
//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя

Console.Write("Input number: ");
int number = Convert.ToInt32 (Console.ReadLine());

int kvadrat = number * number;

//Console.WriteLine("Tne quad of " + number + " is " + kvadrat);

Console.WriteLine($"Tne quad of {number} is {kvadrat}");
*/
//Работа в группах
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Введите первое число ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32 (Console.ReadLine());
int kvadrat = number2 * number2;
if(number1 == kvadrat)
{
    Console.Write("Первое число является квадратом второго");
}
else
{
    Console.Write("Первое число не является квадратом второго");
}
*/ 

//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Введите число ");
int number1 = Convert.ToInt32 (Console.ReadLine());

int current = number1 * (-1);

while(current <= number1)
{
    Console.Write(current + " ");
    current++;
}
