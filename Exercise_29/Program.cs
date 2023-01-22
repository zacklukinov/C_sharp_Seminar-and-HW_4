// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем.

int [] Array = new int[8];

for (int i = 0; i < Array.Length; i++ )
{
    Console.Write($"\nВведите элемент массива с индексом {i}:\t");
    Array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива:");

for (int i = 0; i < Array.Length; i++)
{
    Console.WriteLine(Array[i]);
}
Console.ReadLine();
