/* Задача 1: Напишите программу, которая принимает на вход число
 и проверяет, кратно ли оно одновременно 7 и 23.


Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine($" число {num} кратно 7 и 23");
}
else {
    Console.WriteLine($" число {num} некратно 7 и 23");
} */




/* Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и 
выдаёт номер координатной четверти плоскости, в которой находится эта точка. 

Console.WriteLine(" введите координаты оси Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" введите координаты оси Y: ");
int y = Convert.ToInt32(Console.ReadLine()); 

if (x < 0 && y < 0)
{
    Console.WriteLine(" ваша точка находится в 3 плоскости ");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine(" ваша точка находится в 4 плоскости ");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine(" ваша точка находится в 1 плоскости ");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine(" ваша точка находится во 2 плоскости ");
}
else if ( x == 0 || y == 0)
{
    Console.WriteLine("ваша точка лежит на оси координат, ни в какой плоскости ");
}



Задача 3: Напишите программу, которая принимает
 на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа. 

//Console.WriteLine(" введите число от 10 до 99: ");
//int n = Convert.ToInt32(Console.ReadLine());


int num = new Random().Next(10, 100);
//Console.WriteLine(num);

int num1 = num / 10;
//Console.WriteLine(num1);

int num2 = num % 10;
//Console.WriteLine(num2);

if (num1 > num2)
{
    Console.WriteLine($" наше число: {num}, первое число {num1} больше {num2}");
}
else if  (num1 == num2)
{
Console.WriteLine($" цифры числа {num} одинаковые ");
}
else 
{
    Console.WriteLine($" наше число: {num}, первое число {num1} меньше {num2}");
}
*/



// Задача 4: Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры через запятую.

// Console.WriteLine("введите число от 10 до 100.000 ");
int num = new Random().Next(10, 100000);                    //  Convert.ToInt32(Console.ReadLine());       ///
Console.WriteLine(num);

int res = 0;
if (num < 10)
{
    Console.WriteLine($"второй цифры нет:{num}");
}
else 
 {

    while (num > 0)
    {

        res = num % 10;
        //Console.Write(res);
        num /= 10;

        // Console.Write($" {num} {res}, ");
         Console.Write($" {res} ,");
         //Console.WriteLine(); 
    };
}; 

// другие варианты решения, не совсем правильные 
/* int num = new Random().Next(10, 1000000);
Console.WriteLine(num);
int res = 0; //num % 10;

while ( num <= 0)
{    res = num % 10;
     Console.Write(res);
     num /= 10;
     Console.WriteLine(num);
     Console.WriteLine();
   //num++;
}
// else 
//{
     //Console.WriteLine("no");
     
//}
// Console.Write($"{res},"); 


Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;
if (n < 10)
{
    Console.Write(n);
}
else
 {
    while (n > 0)
    res = n % 10;
    n /= 10;
     {
        Console.Write($" {res} ,");
     }
}




/* 
using System;
class Program
{
static void Main()
{
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
Console.WriteLine(N);
}
else
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}
}
} 





решения с семинара:

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int res_01 = num / 100;
int res_02 = num % 100 / 10;
int res_03 = num % 100 % 10;
Console.Write($"{res_01}, ");
Console.Write($"{res_02}, ");
Console.Write($"{res_03}");


//
Console.WriteLine("введите число");
int digit = int.Parse(Console.ReadLine()!);
if (digit < 10)
{
    Console.WriteLine(digit);
}
else
{
    string s = digit.ToString();
    for (int i = 0; i <= s.Length - 1; i++)
    {
        if (i == s.Length - 1)
        {
            Console.Write(s[i]);
        }
        else
        {
            Console.Write($"{s[i]},");
        }
    }
}




*/