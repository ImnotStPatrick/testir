/* одномерный массив
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

using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        //Напишите свое решение здесь
    }

// Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        //Напишите свое решение здесь
    }

// Обмен элементами массива
    public static void SwapItems(int[,] array, int i)
    {
       //Напишите свое решение здесь
    }

    public static void PrintResult(int[,] numbers)
    {
        //Напишите свое решение здесь
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
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
}
// еще задачи