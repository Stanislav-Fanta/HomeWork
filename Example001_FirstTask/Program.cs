Console.Clear();

static void FillArray(ref int[,] array) {
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            array[i,j] = new Random().Next(1,15);
        }
    }
}




//              Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] arr = new int[4,4];

// FillArray(ref arr);

// SortArray(ref arr);

// for(int i=0; i<arr.GetLength(0); i++){
//     System.Console.WriteLine("[");
//     for(int j=0; j<arr.GetLength(1); j++){
//         System.Console.WriteLine(arr[i,j]);
//     }
//     System.Console.WriteLine("]");
// }


// static int[,] SortArray(ref int[,] array) {
//     int[,] sortedarray = new int[4,4];
//     for(int i=0; i<array.GetLength(0); i++){

//         List<int> arrayline = new List<int>();

//         for(int j=0; j<array.GetLength(1); j++){
//             arrayline[j] = array[i,j];
//         }

//         for(int j=0; j<array.GetLength(1); j++){
//             sortedarray[i,j] = arrayline.Max();
//             arrayline[arrayline.IndexOf(arrayline.Max())] = 0;
//         }

//     }return sortedarray;
// }

// Unhandled exception. System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')
//    at System.Collections.Generic.List`1.set_Item(Int32 index, T value)
//    at Program.<<Main>$>g__SortArray|0_1(Int32[,]& array) in D:\GB\Изучение C#\ДЗ\Example001_FirstTask\Program.cs:line 35
//    at Program.<Main>$(String[] args) in D:\GB\Изучение C#\ДЗ\Example001_FirstTask\Program.cs:line 9

// Не могу понять в чем ошибка




//               Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] arr = new int[4,5];

// FillArray(ref arr);

// for(int i=0; i<arr.GetLength(0); i++){
//     System.Console.Write("[");
//     for(int j=0; j<arr.GetLength(1); j++){
//         System.Console.Write($"{arr[i,j]} ");
//     }
//     System.Console.WriteLine("]");
// }

// System.Console.WriteLine(MinLineSum(arr));


// static int MinLineSum(int[,] array){
//     int minSum = 0;
//     for(int i=0; i<array.GetLength(0); i++){
//         int lineSum = 0;
//         for(int j=0; j<array.GetLength(1); j++){
//             lineSum += array[i,j];
//         }
//         if(i == 0){
//             minSum = lineSum;
//         } else if (minSum > lineSum) {
//             minSum = lineSum;
//         }
//     }return minSum;
// }


//               Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] arr1 = new int[2,2];
// int[,] arr2 = new int[2,2];

// FillArray(ref arr1);
// FillArray(ref arr2);


// PrintArray(MultiplyOfArrays(arr1,arr2));


// static int[,] MultiplyOfArrays(int[,] array1, int[,] array2){
//     int[,] multArray = new int[2,2];
//     for(int i=0; i<2; i++){
//         for(int j=0; j<2; j++){
//             for(int z=0; z<2; z++){
//                 multArray[i,j] += array1[i,z]*array2[z,j];
//             }
//         }
//     }return multArray;
// }


// static void PrintArray(int[,] array){
//     for(int i=0;i<array.GetLength(0);i++){
//         System.Console.Write("[");
//         for(int j=0;j<array.GetLength(0);j++){
//             System.Console.Write($"{array[i,j]} ");
//         }
//         System.Console.WriteLine("]");
//     }
// }


//               Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] arr = new int[2,2,2];

// FillTripleArray(ref arr);
// PrintTripleArray(arr);

// static void FillTripleArray(ref int[,,] array) {
//     for(int firInd=0; firInd < array.GetLength(2);firInd++){
//         for(int secInd=0; secInd < array.GetLength(1);secInd++){
//             for(int tirInd=0; tirInd < array.GetLength(0);tirInd++){
//                 // for(int i = new Random().Next(1,20);Array.IndexOf(array,i) != -1;i = new Random().Next(1,10)){
//                     // array[secInd,tirInd,firInd] = i;                                                                 //попытка сделать заполнение неповторяющимися цифрами. Увы, провал :(
//                 // }
//                 array[firInd,secInd,tirInd] = new Random().Next(1,20);
//             }
//         }
//     }
// }


// static void PrintTripleArray(int[,,] array){
//     for(int firInd=0; firInd < array.GetLength(2);firInd++){
//         for(int secInd=0; secInd < array.GetLength(1);secInd++){
//             for(int tirInd=0; tirInd < array.GetLength(0);tirInd++){
//                 System.Console.Write($"{array[firInd,secInd,tirInd]}{(firInd,secInd,tirInd)} ");
//             }
//             System.Console.WriteLine(" ");
//         }
//     }
// }

//               Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

System.Console.WriteLine("Введите количество строк матрицы: ");
int x = System.Console.Read();
System.Console.WriteLine("Введите количество столбцов матрицы: ");
int y = System.Console.Read();
int[,] arr = new int[x,y];

FillArraySpiral(ref arr);
PrintArray(arr);

static void FillArraySpiral(ref int[,] array){
    int indentWidth = 0;
    int indentHight = 0;
    int digit = 1;
    for(int step=0;;step++){
        // PrintArray(array);
        // System.Console.WriteLine($"step : {step}");
        // System.Console.WriteLine($"indentWidth : {indentWidth}");
        // System.Console.WriteLine($"indentHight : {indentHight}");
        // System.Console.WriteLine($"digit : {digit}");
        // System.Console.WriteLine();
        int notFilled = 0;
        for(int i=0;i<array.GetLength(0);i++){
            for(int j=0;j<array.GetLength(0);j++){
                if(array[i,j] == 0){
                    notFilled++;
                }
            }
        }
        if(notFilled==0){
            break;
        }
        if(step==0){
            for(int i=0+indentWidth;i<array.GetLength(0)-indentWidth;i++){
                if(array[indentHight,i]!= 0){
                    break;
                }
                array[indentHight,i] = digit;
                digit++;
            }
            continue;
        } 
        else if(step==1){
            for(int i=1+indentHight;i<array.GetLength(1)-indentHight;i++){
                if(array[i,array.GetLength(1)-1-indentWidth]!=0){
                    break;
                }
                array[i,array.GetLength(1)-1-indentWidth] = digit;
                digit++;
            }
            continue;
        }
        if(step==2){
            for(int i=array.GetLength(0)-2-indentWidth;i>indentWidth-1;i--){
                if(array[array.GetLength(0)-1-indentHight,i]!= 0){
                    break;
                }
                array[array.GetLength(0)-1-indentHight,i] = digit;
                digit++;
            }
            indentWidth++;
            continue;
        }
        else if(step==3){
            for(int i=array.GetLength(0)-2-indentHight;i>indentHight-1;i--){
                if(array[i,indentWidth-1]!=0){
                    break;
                }
                array[i,indentWidth-1] = digit;
                digit++;
            }
            indentHight++;
            step = -1;
            continue;
        }
    }
}

static void PrintArray(int[,] array) {
    for(int i=0;i<array.GetLength(0);i++){
        System.Console.Write("[");
        for(int j=0;j<array.GetLength(0);j++){
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine("]");
    }
}


System.Console.WriteLine(16%2);