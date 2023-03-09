/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

List<int> array = new List<int>();
for (int i = 0; i < 5; i++)
    array.Add(new Random().Next(10));
foreach (int item in array)
    Console.Write($"{item} ");
Console.WriteLine();
List<int> array1 = new List<int>();
for (int i = 0; i < 5; i++)
    array1.Add(new Random().Next(10));
foreach (int item in array1)
    Console.Write($"{item} ");

array.Sort((x, y) => y.CompareTo(x));
array1.Sort((x, y) => y.CompareTo(x));

Console.WriteLine();
Console.WriteLine("В итоге получается вот такой массив:");
foreach (int item in array)
    Console.Write($"{item} ");
Console.WriteLine();
foreach (int item in array1)
    Console.Write($"{item} ");