﻿/* Задание 1. Совместная работа
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
2 => -2, -1, 0, 1, 2 */


Console.Write(" введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;
int a = -n;
 while ( a <= n)
 {
    Console.Write(a);
    Console.Write(' ');
    a = a + 1;
 }