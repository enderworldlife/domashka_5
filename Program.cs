﻿// // Задача 1: Напишите программу, которая на вход принимает позиции элемента 
// // в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] arr = new int[,] {
//     {0,0,0,0,0,0,0,0,0,0,0},
//     {0,1,2,3,4,5,6,7,8,9,10},
//     {0,2,4,6,8,10,12,14,16,18,20},
//     {0,3,6,9,12,15,18,21,24,27,30},
//     {0,4,8,12,16,20,24,28,32,36,40},
//     {0,5,10,15,20,25,30,35,40,45,50},
//     {0,6,12,18,24,30,36,42,48,54,60},
//     {0,7,14,21,28,35,42,49,56,63,70},
//     {0,8,16,24,32,40,48,56,64,72,80},
//     {0,9,18,27,36,45,54,63,72,81,90},
//     {0,10,20,30,40,50,60,70,80,90,100}
// };

// int IndexInput(int[,] array, int input1, int input2){
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(0); j++){
//             if (input1 == i && input2 == j){
//                temp = array[i,j]; 
//             }
//         }
//     }
//     return temp;
// }

// Console.WriteLine("Здравствуйте. Это программа с двумерным массивом, на примере таблицы умножения.");

// Console.Write("Введите первое число: ");
// int input1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int input2 = Convert.ToInt32(Console.ReadLine());


// int indexArray = IndexInput(arr, input1, input2);
// Console.WriteLine(indexArray);




// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.



// int[,] array = new int[2, 5] {
//     {0, 1, 2, 3, 4},
//     {10, 11, 12, 13, 14}
// };

// for (int i = 1; i >= 0; i--) {
//     for (int j = 0; j < 5; j++) {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// int[,] massiv = new int[,]{
//     {50,45,76,24,11},
//     {99,78,42,32,89},
//     {88,62,47,94,53},
//     {5, 90,78,19,84}
// };

// int min = 100;
// for (int i = 0; i < 4; i++) {
//     for (int j = 0; j < 5; j++) {
//         if (massiv[i,j] < min){
//             min = massiv[i,j];
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(min);


// Задача 4*(не обязательная): 
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового 
// двумерного массива без строки и столбца


// Прошу прощения четвертое задание сделать у меня не получилось.

// int[,] arr = new int[,]{
//     {1,2,3},
//     {1,2,3},
//     {1,2,3}
// };

// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(arr);

// int[,] DeleteArrayFirstElement(int[,] array){
//      int[,] array2 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i != 0 || j !=0 ){
//                 array2[i,j] = array[i,j];
//             }
//         }
//     }
//     return array2;
// }

// Console.WriteLine();

// int[,] deleted = DeleteArrayFirstElement(arr);
// PrintArray(deleted);


