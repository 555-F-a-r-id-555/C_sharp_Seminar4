// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void function()
{
    int[] a = new int[8];
    for (int i = 0; i < 8; i++) a[i] = Random.Shared.Next(0, 2);
    foreach (int value in a) Console.Write($"{value} ");
}

function();