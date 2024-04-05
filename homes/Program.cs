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

//Console.Clear();
//Console.WriteLine("спасибо любимый");

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
/*
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
*/
// Console.Clear();




// двухмерные массивы!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
или
"Позиция по колонкам выходит за пределы массива"

Позиции в массиве считать от единицы.



using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Поиск элемента по позициям
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
        {
            int[,] numbers = new int[,] {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            
            int result = FindElementByPosition(numbers, x, y);
            {
                return result;
            }

        }
    }

// Проверка позиций на вхождение в массив
    public static int ValidatePosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
        if (x < 1 || x > array.GetLength(0))
        {
            Console.WriteLine("позиция за пределами массива");
            return -1;
        }
         if (y < 1 || y > array.GetLength(1))
         {
            Console.WriteLine("позиция не в массиве ");
            return -1;

         }
         return array [x - 1, y - 1];
    }

    public static void PrintResult(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
       
        int res = ValidatePosition(array, x, y); // результат функции передала в переменную
        {
            Console.WriteLine(res);
        }
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {   
        int[,] array;

        int x, y;

        if (args.Length >= 3)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            array = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }

            // Парсинг x и y из аргументов
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                // Теперь у вас есть двумерный массив "array" и координаты x и y
                UserInputToCompileForTest.PrintResult(array, x, y);
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {
           
            // Если аргументов на входе нет, используем примерный массив
            array = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            x = 2;
            y = 2;
            
            UserInputToCompileForTest.PrintResult(array, x, y);

        }                
    }
}

*/


/* Задайте прямоугольный двумерный массив. Напишите программу, которая
 будет находить строку с наименьшей суммой элементов.

Начальные условия:

// Начальные условия
int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};
Выводится: 1
*/

//int[,] PrintArr (int[,] numbers)
/*
{
    int[,] number = new int[,] {
        {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
    };
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for(int j = 0; j < number.GetLength(1); j++)
        {
           Console.Write($"{number[i, j]} ");
        }
        Console.WriteLine();
    }
} //Console.WriteLine();
*/


/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] CreateArray(int m, int n)
{
  int[,] array = new int[m, n];
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] FillArrayRandom(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

int SumRowArray(int[,] array)
{
  int[] sumArr = new int[array.GetLength(0)];
  // Console.WriteLine($"Сумма по строке:");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sumArr[i] += array[i, j];
    }
   // Console.WriteLine($"{i + 1} -> {sumArr[i]}");
  }
  int minSum = sumArr[0];
  int minRow = 1;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    if (sumArr[i] < minSum)
    {
      minSum = sumArr[i];
      minRow = i + 1;
    }
  }
  return minRow;
}

int[,] array = CreateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));
array = FillArrayRandom(array);
PrintArray(array);
int row = SumRowArray(array);
Console.WriteLine($"Наименьшая сумма в {row} строке.");
 */ //код работает


// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

/*

public class Task1
{
public static void Main(string[] args)
{
// Инициализация двумерного массива символов
char[,] charArray = new char[,] { { 'a', 'b', 'd'}, { 'c', 'd', 'e' } };
// Вызов метода для создания строки из 2D массива
string result = CreateStringFrom2DArray(charArray);
// Вывод результата
Console.WriteLine(result);
}
// Метод для создания строки из двумерного массива символов
public static string CreateStringFrom2DArray(char[,] array)
{
string result = "";
// Цикл по каждому элементу в двумерном массиве
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
// Добавление каждого символа в результирующую строку
result += array[i, j];
}
}
    return result; // 

}
} 
*/



/* // решенная задача

public class Task1
{
  public static void Main  (string[] args) // public static void Main(string[] args)
{
  char[,] chars = new char[,] { { 'a', 'b', 'd'}, { 'c', 'd', 'e' } }; //char[,] charArray = new char[,] { { 'a', 'b', 'd'}, { 'c', 'd', 'e' } };
  string result = CharString(chars); // string result = CreateStringFrom2DArray(charArray);
  Console.WriteLine(result); // Console.WriteLine(result);
}

  public static string CharString (char[,] chars) // public static string CreateStringFrom2DArray(char[,] array)
{
    string result = ""; // string result = "";
    for (int i = 0; i < chars.GetLength(0); i++) // for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++) // for (int j = 0; j < array.GetLength(1); j++)
        {
            result += chars[i, j]; // result += array[i, j];
        }
        
    }
    return result; // return result;
    
}
}
*/

/*
using System.Xml.XPath;
public class Task1
{
public static void Main (string[] arg) // создаем одномерный массив из двумерного
{
  char[,] mas = new char[,] { {'a', 'b', 'c'}, {'d', 'e', 'f'} };
  string result = Message(mas);
  Console.WriteLine(result);
}

public static string Message (char[,] mas)
{
    string res = "";
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            res += mas[i, j];
        } 
    }
    return res;
}
}

*/

// Console.Clear(); работает.
/* 
public class Home1
{
    public static void Main (string[] a)
    {
        char[,] x = new char[,] { {'a', 'b'}, {'c', 'd'} };
        string love = Loving(x);
        Console.WriteLine(love);
    }

    public static string Loving (char[,] x)
    {
        string answer = "";
        for (int i = 0; i < x.GetLength(0); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
            {
               answer += x[i, j];
            }
        }
        return answer;
    }
}

*/



//Задача 2: Замена заглавных букв на строчные в строке
/*
public class Task2
{
public static void Main(string[] args)
{
// Входная строка со смешанными буквами обоих регистров
string input = "aBcD1ef!-";
// Преобразование всех заглавных букв в строчные
string result = input.ToLower();
// Вывод результата
Console.WriteLine(result);
}
} */


/* замена больших букв в строке на маленькую
string input = "aUnUluUU1!UaSdUUU";
string result = input.ToLower();
Console.WriteLine(result);
*/


// Console.Clear
/*
Console.WriteLine(" введите данные до 5 символов: ");
string str = Convert.ToString(Console.ReadLine());

  for (int i = 0; i < str.Length / 2; ++i)
       { if (str[i] != str[str.Length - 1 - i]) 
       {
        Console.WriteLine("число или слово не палиндром");
       }
       else 
       {
        Console.WriteLine(" палиндром");
       }
       
       }
   
*/
/*
public class Task4
{
public static void Main(string[] args)
{
// Входная строка со словами, разделенными пробелами
string input = "привет меня зовут";
// Вызов метода для обращения порядка слов в строке
string result = ReverseWords(input);
// Вывод результата
Console.WriteLine(result);
}
// Метод для обращения порядка слов в строке
public static string ReverseWords(string str)
{
// Разделение строки на слова
string[] words = str.Split(' ');
// Обращение порядка слов
Array.Reverse(words);
// Соединение слов обратно в строку с пробелами
return string.Join(" ", words);
}
} */




/*
public class Task4
{
public static void Main(string[] args)
{
// Входная строка со словами, разделенными пробелами
string input = "привет меня зовут";
// Вызов метода для обращения порядка слов в строке
string result = ReverseWords(input);
// Вывод результата
Console.WriteLine(result);
}
// Метод для обращения порядка слов в строке
public static string ReverseWords(string str)
{
// Разделение строки на слова
string[] words = str.Split(' ');
// Обращение порядка слов
Array.Reverse(words);
// Соединение слов обратно в строку с пробелами
return string.Join(" ", words);
}
} вернусь к этому позже */



// вывод  МАССИВА на экран
/*
 int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 
 int[,] PrintMas(int[,] numbers)
 {
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]} ");
            
        }
        Console.WriteLine();
        
    }
    return numbers;
 }

 int[,] x = PrintMas(numbers);
Console.WriteLine(x); */





//{
//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
//class UserInputToCompileForTest
//{
// Печать массива
// public static 
/*
 void PrintArray(int[,] array)
 {
     //Напишите свое решение здесь
    for(int i = 0; i < array.GetLength(0); i++)
 {
     for (int j = 0; j < array.GetLength(1); j++)
     {
         Console.Write($"{array[i, j]} ");

     }
     Console.WriteLine();

 }
 //return array;
}

 //}

// Обмен первой с последней строкой
// public static
  int[,] SwapFirstLastRows(int[,] array)
 {
     //Напишите свое решение здесь
     for(int i = 0; i < array.GetLength(1); i++)
         {
             var tmp = array[2, i];
             array[2, i] = array[0, i];
             array[0, i] = tmp;
             Console.WriteLine($"{tmp}, {array[2, i]}");
         }

 }

// Обмен элементами массива
 //public static 
 //void SwapItems(int[,] array, int i)
 //{
    //Напишите свое решение здесь
 //}

 //public static
  void PrintResult(int[,] numbers)
 {
     //Напишите свое решение здесь
    for(int i = 0; i < numbers.GetLength(0); i++)
         {
             for(int j = 0; j < numbers.GetLength(1); j++)
             {
                 Console.Write(numbers[i,j] + " ");
             }
             Console.WriteLine();
         }
 }
//}

//Не удаляйте и не меняйте класс Answer!
//class Answer
//{
 //public static
  void Main(string[] args)
 {
     int[,] numbers;

     if (args.Length >= 1)
     {
         // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
         string[] rows = args[0].Split(',');

         int rowCount = rows.Length;
         int colCount = rows[0].Trim().Split(' ').Length;

         numbers = new int[rowCount, colCount];

         for (int i = 0; i < rowCount; i++)
         {
             string[] rowElements = rows[i].Trim().Split(' ');

             for (int j = 0; j < colCount; j++)
             {
                 if (int.TryParse(rowElements[j], out int result))
                 {
                     numbers[i, j] = result;
                 }
                 else
                 {
                     Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                     return;
                 }
             }
         }
     }
     else
     {
         // Если аргументов на входе нет, используем примерный массив
        numbers = new int[,]
         {
             {1, 2, 3, 4},
             {5, 6, 7, 8},
             {9, 10, 11, 12}
         }; 
     }
     UserInputToCompileForTest.PrintResult(numbers);
 }



*/
// решение 
/*
    var array = new int[3, 4]
            { { 1, 2, 3, 4 },
              { 0, 0, 0, 0 },
             
              { 5, 6, 7, 8 }
            };
            for(int i = 0; i < array.GetLength(1); i++)
            {
                var tmp = array[2, i];
                array[2, i] = array[0, i];
                array[0, i] = tmp;
            }
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
    */



/*

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12},
    {13, 14, 15, 16,},
    {17, 18, 19, 20},
    {21, 22, 23, 24, 25}
};

void Mas (int[,] array) // вывод массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Pere (int[,] array)
{  
    for(int i = 0; i < array.GetLength(1); i++)
            {
                var tmp = array[4, i];
                array[4, i] = array[0, i];
                array[0, i] = tmp;
            }
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            
}




Mas(numbers); //вывод массива на экран
Pere(numbers); // вывод перевернутого массива на экран

*/
 



 // ответ нейросети
/*
 int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12},
    {13, 14, 15, 16,},
    {17, 18, 19, 20}
   // {21, 22, 23, 24,}
};
Console.WriteLine("исходный массив ");
PrintArray(numbers);
/*
int temp;
int n = numbers.GetLength(1);
for (int i = 0; i < n; i++)
{
    temp = numbers[0, i];
    numbers[0, i] = numbers[numbers.GetLength(0) - 1, i];
    numbers[numbers.GetLength(0) - 1, i] = temp;
}
*/
/*
Console.WriteLine("массив после обмена строк: ");
 void Pere (int[,] numbers)
 {
int temp;
int n = numbers.GetLength(1);
for (int i = 0; i < n; i++)
{
    temp = numbers[0, i];
    numbers[0, i] = numbers[numbers.GetLength(0) - 1, i];
    numbers[numbers.GetLength(0) - 1, i] = temp;
   // Console.Write($"{temp} ");
}
 }

 int[,] zz = Pere;
PrintArray(zz);

void PrintArray(int[,] numbers)
{
    for  (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]}   ");
        }
        Console.WriteLine();
    }
}
*/




int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12},
    {13, 14, 15, 16 }
};

void Mas(int[,] array) // вывод массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Pere(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        var tmp = array[3, i];
        array[3, i] = array[0, i];

        array[0, i] = tmp;
        {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[k, j] + " ");
            }
            Console.WriteLine();
        }

    }
    }

    Mas(numbers);
    Console.WriteLine(" empty ");
    Pere(numbers); }
