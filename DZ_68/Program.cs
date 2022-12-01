//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите значение m:");
int m = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите значение n:");
int n = int.Parse(Console.ReadLine()?? "");

Console.Write($"m = {m}, n = {n} -> A(m,n) = {Akerman(m, n)}");

//-------------Logic--------------//

int Akerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    {  
        if ((n != 0) && (m == 0))
            return Akerman(n - 1, 1);
        else
            return Akerman(n - 1, Akerman(n, m - 1));
    }
}
