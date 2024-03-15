/* Задание 1. Совместная работа
Семинар 1. Знакомство с языками программирования
Напишите программу, которая на вход
принимает два целых числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 => да
a = 2, b = 10 => нет
a = 9, b = -3 => да
a = -3, b = 9 => нет 

Console.Write("введите первое число: ");
// string input a = Console.ReadLine();
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число: ");
// string input b = Console.ReadLine();
int b = Convert.ToInt32(Console.ReadLine());
//int result = b * b;
 if ( a ==  b * b ) //result) // b * b)
 {
    Console.Write(" первое число является квадратом второго ");
 }
 else 
 {
    Console.Write(" первое число не квадрат ");
 } */


/* Напишите программу, которая на вход принимает
целое число N, а на выходе показывает все целые
числа в промежутке от -N до N.
Примеры
4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
2 => -2, -1, 0, 1, 2 


Console.Write(" введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;
int a = -n;
while ( a <= n)
{
   Console.Write($"{a} ");
   // Console.Write(' ');
    a++ ; //a = a + 1;
} 

/* Задание 3*. Работа в сессионных залах
Семинар 1. Знакомство с языками программирования
Напишите программу, которая принимает на вход
трёхзначное целое число и на выходе показывает сумму
первой и последней цифры этого числа.
456 => 10
782 => 9
918 => 17 

Console.WriteLine(" введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 100;
int b = n % 10; 
int sum = (a + b); // / 10;

if (n < 100 || n > 1000)
{
   Console.Write("это не трехзначное число...");
}
else 
{
   Console.Write($" сумма первого и третьего числа {n} равна {sum} ");
} 
// решили на семинаре

int n=Convert.ToInt32(Console.ReadLine());
int first= n%10;
 int second= n/10%10;
  int third= n/100;
  int sum=first+third;
Console.WriteLine(first);
Console.WriteLine(second);
Console.WriteLine(third);

  Console.WriteLine(sum);


  // еще раз решили 
  int n = int.Parse(Console.ReadLine());
int firstNum = n/100;
int lastNum = n%10;
int sum = firstNum + lastNum;
Console.WriteLine(sum);
Console.WriteLine((n/10)%10);


еще раз 
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number<999)
{
    int firstDigit = number /  100;
    int thirdDigit = number % 10 ; 
    int result = firstDigit  + thirdDigit;
    Console.WriteLine("Сумма чисел =  " + result);
}
else
{
    Console.WriteLine("Число не трехзначное ");
}



Console.WriteLine(" введите трехзначное число: ");
string n = Console.ReadLine()!;

if (n.Length != 3)
{
    Console.Write("это не трехзначное число...");
}
else 
{
    Console.WriteLine(Convert.ToInt32(Convert.ToString(n[0])) 
                                         + Convert.ToInt32(Convert.ToString(n[2])));
}




Console.WriteLine(" введите трехзначное число: ");
string n = Console.ReadLine()!;

if (Convert.ToInt32(n) < 100 || Convert.ToInt32(n) > 1000)
{
    Console.Write("это не трехзначное число...");
}
else 
{
    Console.WriteLine(Convert.ToInt32(Convert.ToString(n[0])) 
                                         + Convert.ToInt32(Convert.ToString(n[2])));
}


задача для меня, придумала сама: Напишите программу, которая принимает на вход
целое число и на выходе показывает последнюю цифру этого числа.
456 => 6
782 => 2
918 => 8 

Console.WriteLine(" введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n % 10;
Console.WriteLine(a); 





// домашнее задание, 1. 
using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже


if (firstNumber < secondNumber) 
{
 Console.WriteLine($"первое число меньше второго");
}
if (firstNumber > secondNumber) 
{
  Console.WriteLine($"первое число больше второго");
}
if (firstNumber == secondNumber)
 {
   Console.WriteLine($"числа равны");
  }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 8;
            secondNumber = 8;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}  



// second task 
using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)

    {
      // Введите свое решение ниже
int result = a;
if (b > result) result = b;
if (c > result) result = c;

    {
     Console.WriteLine(" ");
     return result;
     }
  


    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
         
          a = 0;
          b = 6;
          c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
} 



// third 

using System;

class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже
 if (number % 2)
     {Console. WriteLine(" четное");
    }
  else 
  {
   Console.WriteLine("не четное ");
  }

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        }
         else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}
}  


//fourth 

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже


    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
} здесь решить 


Console.Write(" введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n % 2;
//int i = a / 2 ;


if ( a <= n ) // / 2 ))
{
  // i++ ;
   Console.Write($"{a}");
   Console.Write(' ');
    a++; //  i++ ;
} 
else 
{
   Console.WriteLine("число не четное");
} */


// правильное решение

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2; //number % 2;
while (i <= number)  //% 2 )
{
   Console.Write($" {i} ");
   // Console.Write($" {i} ");
            i = i + 2;
}
  /* else // (i != n % 2);
{
   Console.Write("нечетное");
} */