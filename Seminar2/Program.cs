//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//25 % 10 -> 5
//25 / 10 -> 2

//1423 % 10 -> 3
//1423 % 100 -> 23
//1423 % 1000 -> 423

//1423 / 10 -> 142
//1423 / 100 -> 14
//1423 / 1000 -> 1

//1423 % 1000 -> 423 / 10 -> 42

/*
int FindBiggerDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;

    int max;
    if(ed > dec) max = ed;
    else max = dec;

    return max;
}


int randNumber = new Random().Next(10,100);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}");
*/

//Работа в группах
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//625
/*
int DeleteSecondDigit(int num) 
{
    int ed = num % 10;
    int hun = num / 100;

    int result = hun * 10 + ed;

    return result;
}

int randNumber = new Random().Next(100,1000);
int TwoDigit = DeleteSecondDigit(randNumber);

Console.WriteLine($"From a three - digit {randNumber} get a {TwoDigit}");
*/

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.
/*
void NumberMultipleFirst(int number1, int number2)
{
    if(number1 % number2 == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
        Console.WriteLine(number1 % number2);
}

Console.Write("Enter 1st value: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd value: ");
int num2 = Convert.ToInt32(Console.ReadLine());

NumberMultipleFirst(num1, num2);
*/