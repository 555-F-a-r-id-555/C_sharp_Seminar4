// int function(int a)
// {
//     int i;
//     for (i = 1; i < a;) return i += 3;
//     return i += 2;
// }
// Console.WriteLine($"{function(5)}");


// Задача 24: Напишите программу, которая принимает на
// вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int readNumber(string message)
{
    Console.WriteLine($"{message}");
    int value = Convert.ToInt16(Console.ReadLine());
    return value;
}

int SumNum(int a)
{
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum += i;
    }

    return sum;
}
//Console.WriteLine($"{SumNum(7)}");

int num = readNumber("input number");
int resul = SumNum(num);
Console.WriteLine(resul);