Console.Clear();

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
double[,] arr = new double[a,b];

fillarray(ref arr);
printarrey(arr);

static void fillarray(ref double[,] arrey) {
    for(int i=0; i<arrey.GetLength(0); i++){
        for(int j=0; j<arrey.GetLength(1); j++){
            arrey[i,j] = new Random().Next();
        }
    }
}

static void printarrey(double[,] arrey){
    for(int i=0; i<arrey.GetLength(0); i++){
        for(int j=0; j<arrey.GetLength(1); j++){
            System.Console.Write($"{arrey[i,j]} ");
        }
        System.Console.WriteLine(" ");
    }
}