//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    if(n > 1) ShowNums(n - 1);

    Console.Write(n + " ");
}
ShowNums(5);
*/
//Напишите программу, которая будет принимать на вход число 
//и возвращать сумму его цифр.

//5364
/*
int SumOfDigits(int n)
{
    if(n > 0) return SumOfDigits(n / 10) + n % 10;
    else return 0;
}
Console.Write(SumOfDigits(5364));
*/

//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int m, int n)
{
    if(n > m)
    {
    if(n > m) ShowNums(m, n - 1);
    Console.Write(n + " ");
    }
    else
    {
    if(m > n) ShowNums(m, n + 1);
    Console.Write(n + " "); 
    }
}
ShowNums(9, 3);
*/
//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
/*
int PowVaiue(int a, int b)
{
    if(b > 1) return PowVaiue(a, b - 1) * a;
    else return 1;
}
Console.Write(PowVaiue(3, 2));
*/