Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// System.Console.Write("Введите числа через запятую: ");
// string[] arr = System.Console.ReadLine().Split(',');

// System.Console.WriteLine(positive_digits(arr)); 

// static int positive_digits(string[] a){
//     int count = 0;
//     for(int i=0; i<a.Length; i++){
//         if(int.Parse(a[i]) > 0){
//             count++;
//         }
//     } return count;
// }

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

System.Console.Write("b1 = ");
double b1 = double.Parse(System.Console.ReadLine());
System.Console.Write("k1 = ");
double k1 = double.Parse(System.Console.ReadLine());
System.Console.Write("b2 = ");
double b2 = double.Parse(System.Console.ReadLine());
System.Console.Write("k2 = ");
double k2 = double.Parse(System.Console.ReadLine());

System.Console.WriteLine($"({b2-b1/k1-k2}, {k1*(b2-b1/k1-k2)+b1})");
