Console.Clear();

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// double[,] arr = new double[a,b];

// fillarray(ref arr);
// printarrey(arr);

// static void fillarray(ref double[,] arrey) {
//     for(int i=0; i<arrey.GetLength(0); i++){
//         for(int j=0; j<arrey.GetLength(1); j++){
//             arrey[i,j] = new Random().Next();
//         }
//     }
// }

// static void printarrey(double[,] arrey){
//     for(int i=0; i<arrey.GetLength(0); i++){
//         for(int j=0; j<arrey.GetLength(1); j++){
//             System.Console.Write($"{arrey[i,j]} ");
//         }
//         System.Console.WriteLine(" ");
//     }
// }




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] arr = new int[10, 10];

// fillarray(ref arr);

// static void fillarray(ref int[,] arrey) {
//     for(int i=0; i<arrey.GetLength(0); i++){
//         for(int j=0; j<arrey.GetLength(1); j++){
//             arrey[i,j] = new Random().Next(0,20);
//         }
//     }
// }

// System.Console.WriteLine("Введите позицию элемента: ");
// System.Console.Write("Ряд: ");
// int a = int.Parse(System.Console.ReadLine());
// System.Console.Write("Столбец: ");
// int b = int.Parse(System.Console.ReadLine());

// if(a > arr.GetLength(0) || a<0 || b > arr.GetLength(1) || b<0) {
//     System.Console.WriteLine("Такого элемента нет");
// } else {
//     System.Console.WriteLine(arr[a,b]);
// }




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] arr = new int[10, 10];

FillArray(ref arr);
ArithmeticMean(arr);

static void FillArray(ref int[,] arrey) {
    for(int i=0; i<arrey.GetLength(0); i++){
        for(int j=0; j<arrey.GetLength(1); j++){
            arrey[i,j] = new Random().Next(0,20);
        }
    }
}


static void ArithmeticMean(int[,] arrey){
    for(int i=0; i<arrey.GetLength(0); i++){
        int summ = 0;
        for(int j=0; j<arrey.GetLength(1); j++){
            summ += arrey[i,j];
        };
        System.Console.WriteLine((double)summ/arrey.GetLength(0));
    }
}