/* int[] arr = new int[5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

// Console.WriteLine(arr[5]);

int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
int[] arr3 = { 1, 2, 3, 4, 5 };
// arr = [1,2,3,4,5]
*/


//1.создать массив и заполнить его целыми числами от 1 до n.
//вывесли элементы массива на экран.
/*
int n = 10;
int [] arr = new int[n];
int i = 0;

while (i < arr.Length) //  i < n тоже самое 
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    // Console.Write(" ");
    Console.Write($"{arr[i]} ");
    i = i + 1;
} */ // эта задача, ее цикл подойдет для всех задач, 
     // где нужно просмотреть все элементы массива


// 2. задать целочисленный массив на 10 элементов и заполнить его 
// произвольными числами. вывести на экран четные элементы массива.
/* 
int n = 11;
int[] array = {25, 0, 501, 43, 787, 8, 359, 10, 30, 8, 512};
int i = 0;
while ( i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");    
    }
    i++;
} // если цикл зациклился. поможет ctrl+c !!!! 
*/


// 3. найти max.
/*
int n = 5;
int[] array = {2, 20, 5, 98, 25};
int i = 0;
int max = array[0];
while (i < n)
{
   if (array[i] > max)
   {
       max = array[i];
   }
   i++;
}
Console.WriteLine(max); */


// 4.for и while в них можно изменять элементы массива, обращение к элементам 
// происходит с помощью операции индексации [] 

// foreach перебирает и копирует все элементы в переменную массива,
// изменить элементы нельзя, они доступны только для чтения,  идут по порядку
/* int[] array = {1, 2, 4, 6574, 5};

foreach (int e in array)
{
    Console.Write(e);

} */

//using System.Globalization;
//using System.Threading.Tasks.Dataflow;
/* вывод чисел массива
int n = 5;
int[] array = {2, 4, 7, 3, 9};
int i = 0;
int max = array[0];

while( i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i++;
}
Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
    
} 
Console.Write(max);


max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.Write(max); */





/* теория английского в программировании. 
int digit = 5; цифра это имя переменной
int amount = 7; количество
int average =  8; среднее 

примеры наименований функций
с использованием глагола 
ReadFile("c:/data.txt"); чтение файла по некоторому пути
WriteLog("message"); пишет в журнал сообщение
ScanDir("c:/data");сканирует директорию на предмет необходимых файлов





Console.Clear();
 int xa = 1, ya = 1,
     xb = 2, yb = 5,
     xc = 4, yc = 8;

 Console.SetCursorPosition(xa, ya);
 Console.WriteLine("+");

 Console.SetCursorPosition(xb, yb);
 Console.WriteLine("+");

 Console.SetCursorPosition(xc, yc);
 Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 1000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;  // на единицу больше
} */


// прорабатываю лекцию еще раз
// 1. создание массива, заполнение элементов и вывод на экран

/* int[] arr = new int[5]; // создали массив на 5 элементов
arr[0] = 45; 
arr[1] = 56;
arr[2] = 1;
arr[3] = 323;
arr[4] = 23754; // заполнили элементы массива случайными целыми числами

Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]); 
Console.WriteLine(); // выводим элементы массива на экран, работает без ошибок.


// 2. заполнение массива сразу же при создании
/*
int[] arr2 = new int[5]{1, 2, 3, 4, 5};
int[] arr3 = {13, 23, 32, 44, 54};

Console.WriteLine(arr2[0]);
Console.WriteLine(arr2[1]);
Console.WriteLine(arr2[2]);
Console.WriteLine(arr2[3]);
Console.WriteLine(arr2[4]);


Console.WriteLine();

//Console.WriteLine(arr3);
Console.WriteLine(arr3[0]);
Console.WriteLine(arr3[1]);
Console.WriteLine(arr3[2]);
Console.WriteLine(arr3[3]);
Console.WriteLine(arr3[4]); */



// 1. создать массив и заполнить его целыми числами от1 до n, 
//вывести элементы на экран.
/* 
int n = 10; // создали переменную
int[] arr = new int[n]; // создали массив с количеством чисел n (введеннре чиисло или сгенерировано через рандом)
int i = 0; // переменная счетчика, которой будем проходитья по элементам массива 

while (i < arr.Length ) // проходимся по элементам массива и заполняем его числами с помощью переменной i
{ // формируем очередной элемент массива i + 1 и поместим его на требуемую позицию массива, начиная с 0, поэтому i изначально равна 0
    arr[i] = i + 1; 
    Console.Write($"{arr[i]} "); // выводим элементы на экран
    i = i + 1; // не забываем перейти к следующему элементу массива путем увеличения его на едицину
} */




// 2. создать целочисленный массив на 10 элементов и заполнить его случайными числами. вывести на экран четные элементы массива 
 /* 
int n = 10; // переменная с количеством элементов в массиве
int[] array = {2, 5, 4, 7, 8, 35, 1, 3, 8, 5}; // задали массив с четкими значениями элементов
int i = 0; // переменная счетчик
while ( i < n) // цикл с условием переменная счетччик меньше количества элементов в массиве
{ // проверка на четность
    if ( array[i] % 2 == 0) // если элемент массива с индексом [i] делится на два без остатка и  результат деления равен 0
    {
        Console.Write($"{array[i]} "); // просим вывести в консоль этот элемент массива по его индексу
    }
    i = i +1; // на этом этапе переходим к следующему элементу массива, путем увеличения индекса на 1
}
*/


// 3. дано н гирь с разным весом. найти максимальный вес
/* 
int n = 5; // переменная с количеством элементов в массиве
int[] array = { 1, 54, 9, 321, 9}; // массив с заданными числами/ весом гирь
int i = 0; // переменная счетчика, которой проходимся по элементам массива
int max = array[0]; // переменная максимального значения с изначальной позицией в начале массива

while ( i < n) // пока i меньше количества чисел в массиве
{
    if ( array[i] > max) // сравниваем текущий индекс в массиве с максимальным значением, если текущий индекс больше максимального
    {
        max = array[i]; // то присваиваем максимальному значению значение текущего элемента
    }
    i = i + 1; // переходим к следующему элементу массива
}
Console.WriteLine(max); // просим консоль вывести максимальное значение
*/



// 4. другие циклы 
// Console.Clear();

int n = 5; // переменная с количеством элементов в массиве
int[] array = { 1, 54, 9, 321, 9}; // массив с заданными числами/ весом гирь
int i = 0; // переменная счетчика, которой проходимся по элементам массива
int max = array[0]; // переменная максимального значения с изначальной позицией в начале массива

while ( i < n) // пока i меньше количества чисел в массиве
{
    if ( array[i] > max) // сравниваем текущий индекс в массиве с максимальным значением, если текущий индекс больше максимального
    {
        max = array[i]; // то присваиваем максимальному значению значение текущего элемента
    }
    i = i + 1; // переходим к следующему элементу массива
}
Console.WriteLine(max); // просим консоль вывести на экран
//Console.WriteLine(' ');
//Console.WriteLine(' '); 


/*max = array[0];
for(int j = 0; j < n; j = j + 1)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}*/

max = array[0];
for (int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
    
} 
Console.Write(max);
 


 max = array[0];
 foreach( int e in array )
 {
    if (e > max)
    {
        max = e;
    }
 }
 Console.WriteLine(max);
