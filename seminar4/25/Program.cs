// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void myPow(int a,int b)
{
    int res = 1;
    for (int i=1; i<=b; i++) res*=a;
    Console.WriteLine($"a^b = {res}");
}


myPow(3,5);
myPow(2,4);