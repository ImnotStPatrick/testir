/* Напишите программу, которая принимает на вход 
 трёхзначное число и удаляет вторую цифру этого числа.

 int num = new Random().Next(100, 1000);
 Console.WriteLine(num);
int num1 = num % 10;
Console.WriteLine(num1);
int num2 = num / 100; 
Console.WriteLine(num2);
Console.WriteLine(num2 + "" + num1);
Console.WriteLine(num2 * 10 + num1);

int result = num2 * 10 + num1;
Console.WriteLine($"{num} -> {result}");
int result2 = Convert.ToInt32((num2 + "" + num1));
Console.WriteLine($"{num} -> {result2}");

string num_str = Convert.ToString(num);
Console.WriteLine(Convert.ToString(num_str[0]) + Convert.ToString(num_str[2]));
Console.WriteLine(num_str[0] + "" + num_str[2]);

nt num = new Random().Next(100, 1000);

Console.WriteLine(num);

int third = num / 10 % 10;
int second = num % 10;

Console.WriteLine(Math.Pow(third,second)); */




/* Напишите программу, которая принимает на вход
трёхзначное число и возводит вторую цифру этого
числа в степень, равную третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1 

using System.Diagnostics;

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int num1 = number % 100;
int num2 = num1 / 10;
int num3 = num1 % 10;
Console.WriteLine($"num1: {num1}");
Console.WriteLine($"num2: {num2}");
Console.WriteLine($"num3: {num3}");
Console.WriteLine($"Результат: {Math.Pow(num2, num3)}");

int i = 1;
int c = num2;
while (i < num3)
{
    c *= num2;
    Console.WriteLine(c);
    i++;
} */


/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если первое число некратно второму, то 
программа выводит остаток от деления 
Console.WriteLine("введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
// int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());
string Test(int first, int second)
{
    if (second == 0) {return "деление на 0";}
    int res = first % second;
    if (res == 0)
    {
        return "да";
    }
    else 
    {
        return $"Нет, {res}";
    }
}

решение препода

string Test(int first, int second)
{
        if (second == 0) { return "Деление на 0!"; }

        int res = first % second;

        if (res == 0)
        {
                return "Да";
        }
        else
        {
                return $"Нет, {res}";
        }
}

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Test(num1, num2));


if (num2 == 0) { Console.WriteLine("Деление на 0!"); }
else
{
        int res = num1 % num2;

        if (res == 0)
        {
                Console.WriteLine("Да");
        }
        else
        {
                Console.WriteLine($"Нет, {res}");
        }
} */

/* Напишите программу, которая выводит третью слева цифру 
заданного числа или сообщает, что третьей цифры нет.

456  =>  67812  =>  191  =>  Третьей цифры нет 

string Test(int num)
{
    if (num > 999)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        return $"{num % 10}";
    }
    else
    {
        return "Третьей цифры нет";
    }
}

Console.WriteLine(Test(Convert.ToInt32(Console.ReadLine())));



 другое решение не работает

using System.Xml.XPath;

int num = new Random().Next(0, 10000);
Console.WriteLine(num);
int res = 0;
if (num < 100 ) {Console.WriteLine($"третьей цифры нет: {num}")};
else {
    while(num >100){
        result = num % 10;
        num /= 10;
        Console.WriteLine($"ответ: {result} ");
    }
} 





int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100) {
    int num2 = num % 100;
    int num3 = num2 % 10;
    Console.WriteLine(num3);
    }
else {
    Console.WriteLine("NEOk");
    } тут показывает последнюю цифру  



using System;

 
  int num = new Random().Next(0,1000000);
Console.WriteLine(num);
int res=0;
if(num<100){Console.WriteLine($"третей цифры нет:{num}");}else{
  
while(num>=100){
 res=num%10; 
 num/=10;

 Console.WriteLine($"число:{num}");
Console.WriteLine($"ответ:{res}");
Console.WriteLine();


}

}  работает, с четвертой задачей поможет эта задача,цикл меньше 10, чтобы запятую не ставить */


