// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
string WriteNum (int stop, int start)
{
    if (start == stop) return Convert.ToString(stop);
    
    return start + " " + WriteNum(stop, start +1);
}

Console.WriteLine("введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(WriteNum(m, n));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
void PrintA (int[] ar, int n)
 {
    if ( n > 0)
    {
        Console.Write($"{ar[n]}  ");
        PrintA(ar, n - 1);
    }
    else Console.WriteLine(ar[0]);
 }


int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
PrintA(array, array.Length - 1);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

 int Depth = 0;
 UInt64 AckermannFunc(UInt64 m, UInt64 n) 
 {
            Depth++;
            if (m == 0)
                return n + 1;
            if (n == 0)
                return AckermannFunc(m - 1, 1);
            return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
        }
 
        
            Console.WriteLine(AckermannFunc(3, 2));
            Console.WriteLine(Depth);






























































































