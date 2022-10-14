// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
Console.Clear();
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вывод массива: ");
Console.WriteLine($"[{string.Join(", ", array)}]");