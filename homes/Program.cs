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
Выводится: 5.15 

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

*/










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





// Задайте массив на 10 целых чисел. Напишите программу,
// которая определяет количество чётных чисел в массиве.

// Начальные условия:

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// Выводится: 6
/*
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
        int b = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0 )
            {
                

                b = b + 1; // счетчик именно тех чисел, которые оказываются четными
                
            }  
        }
        return b;
    }
    
    public static void PrintResult(int[] array)
    {
        //Напишите свое решение здесь
        // int[] arr = new int[0]; 
        int a = CountEvenItems(array); 
        Console.WriteLine(a);
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


//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.

//Начальные условия: правильное решение здесь

//int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
//Выводится: 5.15
/*
using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        //Напишите свое решение здесь
           double min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;

        /* double min = 0;
        for ( int i = 0; i < numbers.Length; i++ )
        {
            if (min < numbers[i])
            {
                min = numbers[i]; // = a;
            }
          }
        return min; 
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        //Напишите свое решение здесь
        double max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;

        
       /* double b = 0;
        for ( int i = 0; i < numbers.Length; i++ )
        {
            if ( b > numbers[i])
            {
               b = numbers[i]; // = b; 
            }
          }
        return b; 
    }
    
    
    
    public static void PrintResult(double[] array)
    {
        //Напишите свое решение здесь
        double z = FindMin(array); // в переменную z сохранился результат, который посчитали в функции FindMax
        double y = FindMax(array);
        Console.WriteLine($" {y - z} ");
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
} */







//Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// using System.Globalization;

// Console.Clear();
/*
int n = 10; // переменная, которая имеет число равное количеству элементов в массиве
int[] arr = new int[n]; // создание нового массива
int i = 0;

while(i < n)
{
    arr[i] = i +1;
    Console.Write($"{arr[i]} "); // заполнение массива числами от 1 до 10 по порядку и вывод его на экран
    i++;
} */ // создание и выведение массива на экран



/* // здесь готовое правильное решение, работает, однако я сама хочу решить эту задачу по аналогии и по записям в тетради
 Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
 */



// решена задача ниже
/*
 Console.Clear();
 Console.Write(" введите размер массива: "); // просим пользователя ввести число равное количеству чисел в массиве
 int size = Convert.ToInt32(Console.ReadLine()); // считываем данные, введеные пользователем и конвертируем значение в число, помещаем в переменную size
int[] number = new int[size]; // создаем новый массив!!!! размером равному числу в  переменной , значение которой ввел пользователь
FillArray(number); // после того, как написали метод заполнения массива случайными числами, вызываем этот метод с указанием массива
PrintArray(number);
SortArray(number);
Result(number);

// int count = 0; // это переменная для подсчета количества четных чисел в массиве

// напишу метод, который заполняет массив рандомными числами 
void  FillArray (int[] number) // метод void ничего не возвращает, fill array это имя функции, означает заполнить массив. в скобках передан массив,  который нужно заполнить
{ 
    for (int i = 0; i < number.Length; i++) // цикл for проходится по массиву своей переменной i и заполняет массив числами
 {
    number[i] = new Random().Next(100, 1000); // то есть число в массиве number в установленной ячейке [i] на текущий момент заполняется / записывается случайным числом из промежутка от 100 до 999 (последнее число диапазона не учитывается)
 }
}
 // напишу метод, который выводит наш массив на экран
void PrintArray (int[] number) // void ничего не возвращает, print array это имя функции, в которую передаем массив int[] number для распечатки
{
    for (int i = 0; i < number.Length; i++ )
    {
        Console.Write($"{number[i]} ");
    }
    Console.WriteLine();

}
 
 // напишу метод, который будет считать количество четных чисел в массиве
 int SortArray (int[]  number)
 {
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] % 2 == 0) // есди число четное, то цикл засчитывает его и именно ЗАСЧИТЫВАНИЕ сохраняется в переменную count, потом сохраняет общее количество совпадений по условию цикла if
        {
          count = count + 1;
        }
    }
    return count;
     
 }

 void Result (int[] number) // метод, который выводит получившееся число = количество четных чисел в массиве
 {
    int a = SortArray(number); // это переменная, в которую  мы передаем результат предыдущего метода, то есть ответ количества четных чисел
    Console.WriteLine(a); // и выводим на экран переменную, значение которой - функция подсчета четных чисел
 }
// решила!!!!!!
*/



//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’
//или при вводе числа, сумма цифр которого чётная.



//Console.InputEncoding = Encoding.Unicode;
//Console.OutputEncoding = Encoding.Unicode; // Это строки для принятия консолью кириллицы и латиницы одновременно

//using System.Globalization;
/* мой код

    while (true) // цикл while будет выполняться до тех пор, пока не соблюдется условие задачи 
{
        Console.WriteLine(" введите число ");
    string input = Console.ReadLine()!; // это СТРОКА с СИМВОЛАМИ, которые так же вводит пользователь
    int number = Convert.ToInt32(input); // input это переменная, которая содержит символы из введеной строки, и мы их конвертируем в числа. переменная  N содержит в себе любое число, которое консоль затребует у пользователя и которое будет постоянно выводиться

    if (input == "q" || input == "Q") // если введеный с консоли символ это q, то просим программу остановиться
    {
        break; // останавливаем программу этой командой
    }
    // этот блок кода работает

    // здесь в этом цикле будем искать сумму всех цифр в числе
    // int sum = 0; // задаем переменную суммы, в которой будет сохраняться результат суммы введенных чисел
                 // int number = Convert.ToInt32(input);

    if (number != 0) //
        int sum = 0;
        sum += number % 10; // вычисляем количество цифр в числе 
    number /= 10;

    if (sum % 2 == 0) // если выполняется условие четности чисел в их сумме, программа завершается
    {
        Console.WriteLine(" сумма чисел четная, программа завершается ");
        break; // завершаем программу
    }
    else // если условие не выполняется
    {
        Console.WriteLine("сумма чисел нечетная, продолжаем "); // выводим сообщение на экран
    }
}
 мой  код 
 /* 

 while (true) // цикл while будет выполняться до тех пор, пока не соблюдется условие задачи 
{
    Console.WriteLine(" введите число ");
    string input = Console.ReadLine()!; // это СТРОКА с СИМВОЛАМИ, которые так же вводит пользователь
    int number = Convert.ToInt32(input); // input это переменная, которая содержит символы из введеной строки, и мы их конвертируем в числа. переменная  N содержит в себе любое число, которое консоль затребует у пользователя и которое будет постоянно выводиться

    if (input == "q" || input == "Q") // если введеный с консоли символ это q, то просим программу остановиться
    {
        break; // останавливаем программу этой командой
    }
    if(number != 0)
    {
        int sum = 0;
        while (number != 0) //
        {
            sum += number % 10; // вычисляем количество цифр в числе 
            number /= 10;

            if (sum % 2 == 0) // если выполняется условие четности чисел в их сумме, программа завершается
            {
                Console.WriteLine(" сумма чисел четная, программа завершается ");
                break; // завершаем программу
            }
            else // если условие не выполняется
            {
                Console.WriteLine("сумма чисел нечетная, продолжаем "); // выводим сообщение на экран
            }

        }
    }
} */ // этот блок кода работает

// здесь в этом цикле будем искать сумму всех цифр в числе
// задаем переменную суммы, в которой будет сохраняться результат суммы введенных чисел
// int number = Convert.ToInt32(input);





// правильное решение из ответов, работает



// void Main() 
/*
{
while (true) // Бесконечный цикл
{
Console.Write("Введите число или 'q' для выхода: ");
string input = Console.ReadLine(); // Чтение строки ввода пользователя
if (input == "q") // Проверка на ввод 'q' для выхода
{
break;
}
int number;
if (int.TryParse(input, out number)) // Проверка, является ли ввод числом
{
int sum = 0;
while (number > 0) // Вычисление суммы цифр числа
{
sum += number % 10; // Добавление последней цифры к сумме
number /= 10; // Удаление последней цифры из числа
}
if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
{
Console.WriteLine("[STOP]");
break;
}
}
else // Если ввод не является числом и не 'q', повторить запрос
{
Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
}
}
}

*/





// Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

//Задача 3: Реверсирование одномерного массива
//using System;
//class Program

//static 
/*
void Main()
{
int[] numbers = {1, 3, 5, 6, 7, 8}; // Исходный массив
int temp;
// Вывод исходного массива
Console.Write("Исходный массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}
// Реверсирование массива
for (int i = 0; i < numbers.Length / 2; i++)
{
// Меняем местами элементы
temp = numbers[i];
numbers[i] = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = temp;
}
// Вывод измененного массива
Console.Write("\nПеревернутый массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}
}
// почему то не работает
*/

/*
 */
using System.Globalization;

Console.WriteLine("спасибо любимый");

 // еще раз пробую вывестимассив на экран
 /*
 int[] array = [1, 3, 5, 6, 7, 8];

 void Arr (int[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
 }

Arr(array);
*/ // вывела на экран массив









// решение правильное
int[] array = [1, 3, 5, 6, 7, 8];

void Mas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Mis(int[] array)
{ int t = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        t = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = t;
    }
     Console.WriteLine("измененный массив ");
     foreach (int e in array)
     {
        Console.Write(e + " ");
     }
}


Mas(array); // вызов функции первого массива
Mis(array); // вызов вункции второго массива