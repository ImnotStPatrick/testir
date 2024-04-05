//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
  
  /* int SumNum(int num)
{
    if (num == 0) return 0; // return 0 это стоп для рекурсии
    int res = num % 10 + SumNum(num / 10);
   return res;
}


Console.WriteLine("введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(n));

*/



// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
string Len(int stop, int start = 1)
{
    if (start == stop) return Convert.ToString(stop);
    return start + " " + Len(stop, start + 1);
}

void Len2(int num)
{
    if (num == 0) return;
    Len2(num - 1);    
    Console.Write($"{num} ");
}



Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Len(n));
Len2(n);

//Console.WriteLine(1 + 5); // 6
//Console.WriteLine(1 + " " + 5); // 1 5
//Console.WriteLine(1 + "" +5); //15

//код препода, работает
*/



//Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
/*
void Consonants (string s)
{
    if (s.Length == 0) return;
    string st = "aouei";
    if(st.Contains(s[0]) == false) Console.Write($"{s[0]} ");
    Consonants(s[1..]);
}

void Consonants2 (string s, int i = 0)
{
    string st = "aouyei";
    if (i == s.Length) return;
    if (!st.Contains(s[i]) == false) Console.Write($"{s[i]} "); // !меняет значение на противополжное, true = false, false = true
    Consonants2(s, i +1);
}




string st = Console.ReadLine()!;
Consonants(st);
Consonants2(st);
*/
/*
string st = "qwersdgdgdgdgdgdgdg";
Console.WriteLine(st[2..5]);
string[] mas = new string[]{"1","2", "3"};
string[] mas2 = mas[2..];
Console.WriteLine(mas2[0]);
*/
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
        
    
