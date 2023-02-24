// Задача 29: Напишите программу,
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


void printArray(int  size)
{
    int [] a = new int[size];
    for(int i =0; i < size; i++) a[i]=Convert.ToInt16(Console.ReadLine());
    Console.WriteLine($"[{string.Join(", ",a)}]");        
}

printArray(5);
printArray(3);
