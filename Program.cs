// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // // [345, 897, 568, 234] -> 2

// using System;


// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }


// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array} ");
//     }
//     Console.WriteLine();
// }

// void ProveArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0);
//         Console.WriteLine($"{array[i]} ");
//     }

// }
// Console.WriteLine("Enter the size of the array: ");
// int size = Convert.Toint32(Console.Readline());
// int min = 100;
// int max = 1000;
// int[] arr = CreateArray(size, min, max);
// ShowArray(arr);
// ProveArray(arr);



// // // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // // [10, 11, 12, 13, 14] -> 5


// int[] CreataArray(int size, int minValue, int maxValue){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.WriteLine($"{array[i]}");
//     }
//     Console.WriteLine();
// }

// int ArrayInRange(int [] array, int firstRange, int lastRange){
//     for(int i = 0; i < array.Length; i++){
//         int count = 0;
//         if(array[i] > firstRange && array[i] < lastRange){
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine("Enter the minimal number of the array");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the maximal number of the array");
// int max = Convert.ToInt32(Console.ReadLine());
// int size = 123;
// int arr = CreataArray(size, min, max);
// ShowArray(arr);
// int first = 10;
// int last = 99;
// int res = ArrayInRange(size, first, last);
// Console.WriteLine($"{res} numbers of the array are between {first} and {last}");



// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array} ");
    }
    Console.WriteLine();
}

int SumOfUnEvenNumbers(int [] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 == 1){
            sum = array[i] + array[i+1];
        }
    }
    return sum;
}

Console.WriteLine("Enter the minimal number of the array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the maximal number of the array");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
int arr = CreataArray(size, min, max);
ShowArray(arr);
int res = SumOfUnEvenNumbers(array);
Console.WriteLine($"The summ of elements with uneven indexes is {res}");



// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array [i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }

// void ShowArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array} ");
//     }
//     Console.WriteLine();
// }

// // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21