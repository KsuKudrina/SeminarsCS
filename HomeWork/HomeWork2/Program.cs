//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/* 456 -> 5
   782 -> 8
   918 -> 1 */
/*
int SecondDigitOfNumber(int number)
{
   
   int dec = number % 100;
   int result = dec / 10;

   return result;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SecondDigit = SecondDigitOfNumber(num);
Console.WriteLine($"Вторая цифра числа {SecondDigit}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/* 645 -> 5
   78 -> третьей цифры нет
   32679 -> 6 */
/*
void ThirdDigitOfNumber(int number)
{
   int count = number;
   
   if(count >= 100)
   {
      while (count >= 1000)
      {
         count = count / 10;
      }
   count = count % 10;
   Console.WriteLine(count);
   }
   else
   {
      if(count < 100)
      {
         Console.WriteLine("Третьей цифры нет");
      }
   }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

ThirdDigitOfNumber(num);
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/* 6 -> да
   7 -> да
   1 -> нет*/

void Weekend(int number)
{
   if(number > 5)
   {
      Console.WriteLine("Выходной");
   }
   else
   {
      Console.WriteLine("Будни");
   }
   
}

Console.Write("Введите цифру дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

Weekend(num);