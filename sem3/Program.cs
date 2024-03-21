//Задайте массив. Напишите программу, которая определяет, присутствует
// ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.
/* using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

Console.Write("введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];

//Console.WriteLine(mas);
int ind = 0;

while (ind < mas.Length)

{
   Console.Write($"{mas[ind]} ");
   ind++;
}
Console.WriteLine();

//for  для перебора
for ( int i = 0; i < mas.Length; i++)
{
   Console.Write($"{mas[i]} ");
}
Console.WriteLine();

// foreach просто для перебора, проверяет числа, но не меняет их
foreach ( int item in mas ) // var item in collection
{
   Console.Write($"{item} ");
}
Console.WriteLine(); 


// функция 
void PrintMas(int[] col) // для печати элементов массива
{
foreach (int item in col)
{
   Console.Write($"{item} ");
}
Console.WriteLine();
}
PrintMas(mas); // создали и вывели массив

int[] RandomMas(int[] col);
{
for (int i = 0; i < col.Length; i++);
{
   col[i] = new Random().Next(1, 9);
} 

   return col; 
}

// обращение к функции
int[] new_mas = RandomMas(mas); // обращение к первому массиву
PrintMas(new_mas);
Console.Write("введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int flag = 0;
foreach  ( var item in new_mas)
{
   if (item == 5)
   {
       flag++;
   }
}
if (flag > 0)
{
   Console.WriteLine("да");
}
else 
{
   Console.WriteLine("нет");
}
string S(int[] col, int m)
{
   foreach (var item in col)
   {
       if (col == m) return "да";
}
return "нет";
};
Console.WriteLine(new_mas, m); 



// решение преподавателя 

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];

// Console.WriteLine(mas);

//while
int ind = 0;
while (ind < mas.Length)
{
   Console.Write($"{mas[ind]} ");
   ind++;
}
Console.WriteLine();

//for
for (int i = 0; i < mas.Length; i++)
{
   Console.Write($"{mas[i]} ");
}
Console.WriteLine();

//foreach
foreach (int item in mas)
{
   Console.Write($"{item} ");
}
Console.WriteLine();

//функция
void PrintMas(int[] col)
{
   foreach (int item in col)
   {
       Console.Write($"{item} ");
   }
   Console.WriteLine();
}

PrintMas(mas);

int[] RandomMas(int[] col)
{
   for (int i = 0; i < col.Length; i++)
   {
       col[i] = new Random().Next(1,9);
   }

   return col;
}

int[] new_mas = RandomMas(mas);
PrintMas(new_mas);

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

int flag = 0;
foreach (var item in new_mas)
{
   if (item == m)
   {
       flag++;
   }    
}

if (flag > 0)
{
   Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет");

}

string S(int[] col, int m)
{
   foreach (var item in col)
   {
       if(item == m) return "Да";
   }
   return "Нет";
}

Console.WriteLine(S(new_mas, m));




// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
Замените отрицательные элементы на положительные, а положительные на отрицательные. 

using System.ComponentModel.DataAnnotations;

int n = Convert.ToInt32(Console.ReadLine());

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}


int[] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(-10, 11);
    }

    return col;
}

int[] arr = RandomMas(new int[n]);
PrintMas(arr);

for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1;

}

PrintMas(arr);

// еще одно решение

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        RandomNum(arr);

        Console.WriteLine("Исходный массив:");
        PrintNum(arr);

        Reload(arr);

        Console.WriteLine("Измененный массив:");
        PrintNum(arr);
    }

    static void PrintNum(int[] numbers)
    {
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    static void RandomNum(int[] numbers)
    {
        Random rand = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(-10, 11);
        }
    }

    static void Reload(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                arr[i] *= -1;
            }
            else
            {
                arr[i] *= -1; // для того, чтобы  поменять положительные числа на отрицательные и обратно
            }
        } 
    }
} */


// 3. Найдите произведения пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новый массив.
 /*

int[] Append(int len)
{
    int[] list = new int[len];
    for (int i = 0; i < len; i++)
    {
        list[i] = new Random().Next(-100, 101);
    }
    foreach (int i in list)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    return list;
}

var len = 6;

var lst = Append(len);

var l = lst.Length;

int index = 0;


while (index < lst.Length / 2)
{
    Console.Write(lst[index] * lst[lst.Length - index - 1] + " ");
    
    index++;
}
*/


// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. 
// Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м.

/ int[] arr = { }
// int n = Convert.ToInt32(Console.ReadLine());

string n = Console.ReadLine();
int len = n.Length;

int[] arr = new int[len];
 for ( int i = 0; i < len; i++)
 {
    arr[i] = Convert.ToInt32(Convert.ToString(n[i])); 
 }

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

PrintMas(arr);

int[] arr2 = new int[len];

for ( int i = 0; i < len; i++)
 {
    arr2[i] = Convert.ToInt32(Convert.ToString(n[len - 1 - i])); 
 }
 
 PrintMas(arr2);