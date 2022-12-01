//Task 64. Задайте значение n. Напишите программу, 
//которая выведет все натуральные числа в промежутке от n до 1. Выполнить с помощью рекурсии.

//// Не смог справиться с "error CS0029: Не удается неявно преобразовать тип "int" в "bool"."

int n = 5;
PrintRec(n);

////-----------------Logic--------------------////

int Recursion (int n)
{
    if (n = 1)
    {
        return 1;    
    }

    return Recursion(n - 1); 
}

void PrintRec(int n)
{
    Console.Write($"n = {n} -> "); 

    for (int i = 0; i < n; i++)
    { 
        Console.Write($"{Recursion(n)}, ");
    }
}