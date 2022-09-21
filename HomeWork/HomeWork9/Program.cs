//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
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
ShowNums(1, 9); 
*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int ShowNumsSum(int m, int n)
{
    if(m == n) return m;
    if(m == 0 && n == 0) return 0;
    else
    if(m < n) return m + ShowNumsSum(m + 1 , n);
    else return m + ShowNumsSum(m - 1, n);
} 
   
Console.Write(ShowNumsSum(0, 15)); 
*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29 
//возможно опечатка. m = 2, n = 3 -> A(m,n) = 9; m = 3, n = 2 -> A(m,n) = 29;
/*
int Ackerman(int m, int n)
{
    if(m == 0) return n + 1;
    else
    if(m > 0 && n == 0) return Ackerman(m - 1, 1);
    else 
    if(m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    else return n + 1;
}
Console.Write(Ackerman(3, 2));
*/