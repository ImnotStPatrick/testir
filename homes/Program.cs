// Console.Write("домашняя работа");

// 1 задача, найти количество элементов в массиве в заданном отрезке
//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
/* class UserInputToCompileForTest
{
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        return numbers.Count(x => x >= minRange && x <= maxRange);
    }
 
    public static void PrintResult(int[] array)
    {
        int result = CountItemsRange(array, 10, 90);
 
        // Console.WriteLine($"Массив: {string.Join(", ", array)}");
        Console.WriteLine(result);
    }
 
}
 
 
//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
 
 
        if (args.Length >= 1)
        {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);
 
            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(',')
                                  .Select(int.Parse)
                                  .ToArray();
 
            // Теперь arr содержит преобразованные в целые числа из командной строки
 
        }
        else
        {
            // Если аргументов на входе нет
            array = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 }; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
// код правильный







// 2 задача. int result = CountItemsRange(array, 10, 90);
 
     Задайте массив на 10 целых чисел. Напишите программу, 
     которая определяет количество чётных чисел в массиве.

Начальные условия:

int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
Выводится: 6
*/

/*
while ( i < array.Length)
{
    Console.Write($"{array[i]} ");
    i++;
}
for (int j = 0; j < array.Length; j++)
{

if ( array[i] % 2 == 0)
{
    // int a = array[i] % 2 == 0;
    Console.WriteLine($"{array[i]} ");
    // return true;
     j++;
}
}
Console.WriteLine(); */

/*
int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
int i = 0;
while ( i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i++;
}
Console.WriteLine();
*/
/*
{
    // int result = 0;
    foreach (int e in array)
    if ( e % 2 == 0)
    {
        Console.Write($"{e} ");
    }
} */
/*
for  (int i = 0, i < array.Length; i++)
{

}
while ( result <= array[i]) 
{
    Console.Write($"{result}" );
    //result;
}
}
//  Console.Write(i);






/*
{
int result = CountItemsRange(array, 10, 90);

    // Console.WriteLine($"Массив: {string.Join(", ", array)}");
    Console.WriteLine(result);

};

*/




/* 
//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
        //Напишите свое решение здесь
       
    }
    
    public static void PrintResult(int[] array)
    {
        //Напишите свое решение здесь
        int result = CountEvenItems(numbers % 2);
 
        // Console.WriteLine($"Массив: {string.Join(", ", array)}");
        Console.WriteLine(result);

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
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
*/


/* 
int[] RandomMass(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(1,100);
    }
    return Number;
}

void PrintMass(int[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

bool prost(int num)
{
    for (int i = 2; i < num; i++)
    {
        if(num % i == 0) return false;
    }
    Console.WriteLine(num);
    return true;
}


int Count(int[] col)
{
    int count = 0;
    foreach (var i in col)
    {
        if(prost(i)) count++;
    }
    return count;
}


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = RandomMass(n);
PrintMass(mas);
Console.WriteLine($"Количество простых чисел в массиве равно {Count(mas)}");
*/


// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
/*
int[] Mass(int m)
{
    int[] Number = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; //new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = ; // new Random().Next(1,100);
    }
    return Number;
}

void PrintMass(int[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

bool prost(int num)
{
    for (int i = 2; i < num; i++)
    {
        if(num % i == 0) return false;
    }
    Console.WriteLine(num);
    return true;
}


int Count(int[] col)
{
    int count = 0;
    foreach (var i in col)
    {
        if(prost(i)) count++;
    }
    return count;
}


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = Mass(n);
PrintMass(mas);
Console.WriteLine($"Количество простых чисел в массиве равно {Count(mas)}");






Console.WriteLine("четные 
элементы массива\n" + string.Join(", ", array.Where(x => x % 2 == 0).ToArray().Select(x => x.ToString())));


Console.Clear();
int[] array = new int[10];
int a = 0;
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 11);
    Console.Write($"{array[i]} ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        a = a + 1;
}
Console.Write(a);


*/
/* 
Задайте массив на 10 целых чисел. Напишите программу,
 которая определяет количество чётных чисел в массиве.

Начальные условия: */
/*______________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________-
int[] array = {2, 50002, 2427, 43, 3, 654, 3, 7, 8, 236, 14, 65, 22, }; // Создание массива
for (int i = 0; i < array.Length; i++ )
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int a = 0; 
foreach (int e in array)
{
    if ( e % 2 == 0)
    {
            Console.Write($"{e} ");
            a++;
 }
    }


Console.WriteLine();
Console.Write($"{a} ");
_____________________________________________________________________________________________________________________________________________________________________________________________________________________
*/




/* 
Не все тесты пройдены, есть ошибки :(


Количество затраченных попыток: 1

Время выполнения: 2.338397 сек

Общая статистика
Всего тестов: 3. Пройдено: 0. Не пройдено: 3.

Подробную информацию по каждому тесту смотрите ниже.

Тест 1
Тест не пройден ✗

Формулировка:

* Аргументы, передаваемые в метод/функцию:


'2, 5, 1, 1, 6, 3, 7, 8, 2, 4'


* Итоговый код для проверки.


using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
        //Напишите свое решение здесь
          int a = 0; 
          foreach (int e in numbers)
           {
           if ( e % 2 == 0)
           {
            // Console.Write($"{e} ");
            a++;
           }
    }
    }
    
    public static void PrintResult(int[] array)
    {
        //Напишите свое решение здесь
       int[] result = ; 
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
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
} // Проверяем решение


Ожидаемый ответ:

5

Ошибка:

Cannot open assembly 'M82PM7AN65PKOJ2ZGDD8.exe': File does not contain a valid CIL image.


M82PM7AN65PKOJ2ZGDD8.exe(26,22): error CS1525: Unexpected symbol `;'
Тест 2
Тест не пройден ✗

Формулировка:

* Аргументы, передаваемые в метод/функцию:


'1, 5, 1, 1, 1, 3, 7, 1, 1, 1'


* Итоговый код для проверки.


using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
        //Напишите свое решение здесь
          int a = 0; 
          foreach (int e in numbers)
           {
           if ( e % 2 == 0)
           {
            // Console.Write($"{e} ");
            a++;
           }
    }
    }
    
    public static void PrintResult(int[] array)
    {
        //Напишите свое решение здесь
       int[] result = ; 
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
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
} // Проверяем решение


Ожидаемый ответ:

0

Ошибка:

Cannot open assembly 'FD8U8VGPVNXTCSCEQANV.exe': File does not contain a valid CIL image.


FD8U8VGPVNXTCSCEQANV.exe(26,22): error CS1525: Unexpected symbol `;'
Тест 3
Тест не пройден ✗

Формулировка:

* Аргументы, передаваемые в метод/функцию:


'2, 4, 6, 8, 10, 30, 70, 10, 10, 10'


* Итоговый код для проверки.


using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
        //Напишите свое решение здесь
          int a = 0; 
          foreach (int e in numbers)
           {
           if ( e % 2 == 0)
           {
            // Console.Write($"{e} ");
            a++;
           }
    }
    }
    
    public static void PrintResult(int[] array)
    {
        //Напишите свое решение здесь
       int[] result = ; 
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
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
} // Проверяем решение


Ожидаемый ответ:

10

Ошибка:

Cannot open assembly 'ZE87ONZPV8OFUKQA6SAN.exe': File does not contain a valid CIL image.


ZE87ONZPV8OFUKQA6SAN.exe(26,22): error CS1525: Unexpected symbol `;'
 
 */ 



// вот тут уже затык и никак не идет
/* 
int number = 0; 
for (var i = 0; i < array.Length; i++)
{
    number = array[i];
    i++;

}
Console.WriteLine($"{number}" );
// Console.Write($"{array[]} ");
*/














/* Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.

Начальные условия:

int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
Выводится: 5.15 */

double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
void PrintArray(double[] array)
{
    double count = array.Length;
    for (double i = 0; i < count; i++)
    {
        Console.Write($"{array[(int)i]} || "); // почему int тут взялся??
    }
    Console.WriteLine();
}
PrintArray(array); // задала и вывела массив на экран

// упорядочение массива от min до max
void SelectionSort(double[] array)
{
    for (double i = 0; i < array.Length; i++)
    {
        double min = i;
        for (double j = i + 1; j < array.Length; j++ )
{
    if (array[(int)j] < array[(int)min])
    {
        min = j;
    }
}
      double temporary = (int)array[(int)i];
      array[(int)min] = temporary;  // double temporary = array[i];
    }
} 
PrintArray(array);
SelectionSort(array);
//PrintArray(array);












/*
for (double i = 0; i < numbers.Length; i++)
double max = 0; //5.4;
double min = 0; //0.25;
{
    Console.Write($"{numbers[i]} ; ");
} 
// вывелось
double FindMax(double[] numbers)
{
    /// for (int i = 0; i < numbers.Length; i++)
    double max1 = max;


    {

    }
}


*/