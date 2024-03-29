//Задайте массив. Напишите программу, которая определяет, присутствует
// ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.
// код запоротый, не могу понять сколько там ошибок
// using System.ComponentModel.DataAnnotations;
// using System.Security.Principal;
/* 
Console.Write("введите размер массива: "); // просим пользователя ввести число
int n = Convert.ToInt32(Console.ReadLine()); // конвертируем введенное число из строки в числовое значение ( числовой тип данных)
int[] mas = new int[n]; // создаем новый массив с количеством элементов равному числу пользователя

//Console.WriteLine(mas);
int ind = 0; // пустая переменная длч цикла while, которой будем проходиться по массиву и выводить его числа на экран ( только те числа, которые оказались в заданном массиве) 

while (ind < mas.Length) // пока переменная ind проходится по массиву (меньше количества чисел в массиве)

{
   Console.Write($"{mas[ind]} "); // консоль выводит одно число массива на экран
   ind++; // на этом этапе переходим к следующему элементу массива
}
Console.WriteLine(); // просто пустая строка, чтобы не запутаться в выводах

//for  для перебора
for ( int i = 0; i < mas.Length; i++) // в этом цикле опять же перебираем все элементы массива: создаем переменную счетчика. проводим цикл до тех пор, пока эта переменная меньше количества чисел в массиве, и так же переходим к следующему элементу
{
   Console.Write($"{mas[i]} "); // выводим полученные числа на экран
}
Console.WriteLine(); // пустая строка, чтобы не запутаться в выводах

// foreach просто для перебора, проверяет числа, но не меняет их
foreach ( int item in mas ) // var item in collection. цикл форич проверяет ИХ в заданном массиве (их- они, числа в массиве)
{
   Console.Write($"{item} "); // опять же выводим полученные числа на экран
}
Console.WriteLine(); // пустая строка


// функция 
void PrintMas(int[] col) // для печати элементов массива
{
foreach (int item in col) // проверяет числа в массиве
{
   Console.Write($"{item} "); // выводит числа на экран
}
Console.WriteLine(); // пустая строка
}
PrintMas(mas); // создали и вывели массив, то есть эта строка отсылает к функции и проводит проверку в функии

int[] RandomMas(int[] col); // создаем массив со случайными числами и передаем в параметры новый массив
{
for (int i = 0; i < col.Length; i++); // проходимся по элементам массива и заполняем его случайными числами
{
   col[i] = new Random().Next(1, 9); // случайными числами от 1 до 8, потому что последнее число диапазона не входит в числа
} 

   return col; // ритёрн возвращает значения элементов массива после одной итерации 
}

// обращение к функции
int[] new_mas = RandomMas(mas); // обращение к первому массиву
PrintMas(new_mas); // выводит на экран числа в массиве
Console.Write("введите число: "); // просим пользователя ввести число
int m = Convert.ToInt32(Console.ReadLine()); // конвертируем введеное число из строки в числовой тип данных
int flag = 0; // переменная для проверки нахождения конкретного числа в заданном массиве
foreach  ( var item in new_mas) // проходимя цикорм по массиву
{
   if (item == 5) // если нужное число находится
   {
       flag++; // то передаем нужное искомое число в эту переменную
   }
}
if (flag > 0) // если нужное искомое нами число больше нуля
{
   Console.WriteLine("да"); // выводим результат на экран, что нужное нам число присутсвует в заданном массиве
}
else // если нужного числа нет
{
   Console.WriteLine("нет"); // выводим на экран отрицательный ответ
}
string S(int[] col, int m) // функция для сравнения чисел в найденных переменных 
{
   foreach (var item in col) // проходимся по циклу
   {
       if (col == m) return "да"; // если нужное нам число совпадает с найденным в массиве (5 = 5), то выводим результат ДА
}
return "нет"; // если нужного числа нет, выводим НЕТ
};
Console.WriteLine(new_mas, m); // выводим на экран результаты 

*/

// решение преподавателя правитльное
/*
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

string S(int[] col, int m) // функция сравнения чисел между теми. что есть в массиве и тем. которое нужно найти
{
   foreach (var item in col)
   {
       if(item == m) return "Да";
   }
   return "Нет";
}

Console.WriteLine(S(new_mas, m));
*/


/* 
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
*/

// еще одно решение
/*
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
/* 
// int[] arr = { }
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
 
 PrintMas(arr2); */





/* домашние заадачи 
// 1. Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите 
//количество элементов массива, значения которых лежат в отрезке [10,90].

// Начальные условия:

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5
// Подсказка № 1
Напишите функцию подсчета элементов массива, попадающих в заданный 
диапазон, вызовите эту функцию, выведите результат.
Подсказка № 2
Объявите функцию подсчета элементов массива. В теле функции создайте 
цикл, проходящий по всем элементам массива. В теле цикла создайте 
оператор ветвления с условием, если элемент массива попадает в заданный диапазон,
то увеличиваем счетчик на единицу.
Подсказка № 3
Вызовите функцию. */


/*
using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
         //Введите сюда свое решение

    }
    
    public static void PrintResult(int[] array)
    {
        
          //Введите сюда свое решение
    }

}


//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
} */
/* 

using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

int[] arr = {1, 55, 48, 6, 3, 769, 85};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} || ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] array) // сортируем массив от меньшего к большему
{
    for (int i = 0; i < array.Length; i++)
    {
       int min = i;
        //int temporary = array[i];
        //array[i] = array[min];
        //array[min] = temporary;
        for( int j = i + 1; j < array.Length; j++)
        {
            if ( array[j] < array[min] )
            {
                min = j;
            }
        }
        int temporary = array[i];
        array[i] = array[min];
        array[min] = temporary;
    }
}

 void FindMax (int[] array)
{
int max = 0;
for (int i = 0; i < array.Length; i++)
{
   /* if (max < array[i])
    {
        // найден больший элемент
        max = array[i];
        Console.Write($"{max}      ");
        //i++;
    }
    i++;
    // return max;
    */
    /*
    foreach (int e in array)
    {
        if ( e > max)
        {
             max = e;
             Console.Write(e);
        }
    } 
}
}



/* 
{
    for (int i = 0; i < array.Length; i++)
    {
       int min = i;
       for (int j = i + 0; j < array.Length; j++)
       {
        if ( array[j] < array[min])
        min = j;
        Console.Write($"{min} []");
        j++;
        //Console.Write($"{min} () ");
       }
       int temporary = array[i];
        array[i] = array[min];
        array[min] = temporary;

    }
} */


//PrintArray(arr); // выводит заданный масив
//SelectionSort(arr); // сортирует массив
//PrintArray(arr); // выводит сортированный массив на экран
//FindMax(arr); // вывод минимального числа

/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}
PrintArray(arr); 
 

 //int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 }; 
 void SelectionSort(int[]array)
 {
    for (int i=0; i< array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i +1; j< array.Length; j++)
        {
            if (array[j]<array[minPosition])
            {
                minPosition= j;
            }
        }
        int temporary = array[i];
        array[i]= array[minPosition];
        array[minPosition]= temporary;
 }
 }
 
PrintArray(arr);
SelectionSort(arr);
//Console.WriteLine("arr");
PrintArray(arr); */
















// решение из интернета


Console.Clear();
//Console.Write("Введите массив: ");
// int n = Convert.ToInt32(Console.ReadLine());
double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double max=0;
double a;
double[] array= new double [array];
for (int i=0; i<array.Length;i++)
array [i]= 0; // new Random().NextDouble() *100;
double min = array[0];
for (int i=0; i<array.Length;i++)
{
if (max<array[i])
max=array[i];
}
Console.Write(max);
for (int i=0; i<array.Length;i++)
{
if (min>array[i])
min=array[i];
}
a=max-min;
Console.Write("  и  "+min);
Console.WriteLine("\n");
Console.WriteLine("разница: ");
Console.WriteLine(a);







