// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int res(int a)
{
    int j = 0;
    while (a != 0)
    {
        a /= 10;
        j++;
    }
    return j;
}

void printRes(int a)
{
    Console.WriteLine($"{a} -> {res(a)}");
}

printRes(463);
printRes(89126);