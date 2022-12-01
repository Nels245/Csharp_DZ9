//Task 66. Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int m = 1;
int n = 15;
    
Console.WriteLine($"M = {m}; N = {n} -> {Summary(m,n)}"); 

////-----------------Logic--------------------////

int Summary(int m, int n)
{ 
    int sum = m;

    for (int i = 1; i < (n - m) + 1; i++)
    {
        sum =  m + (sum + i);
    }
    
    return sum;
}

