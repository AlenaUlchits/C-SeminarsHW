void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j], 3}");
        }
        Console.WriteLine();
    }
}
int[,] GenerateArray(int n, int m){
    int[,] arr = new int[n, m];
    for(int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(-10, 10);
        }
    }
    return arr;
}
void FindMinSum(int[,] arr){
    int minSum = 0;
    int rowSum = 0;
    int rowWithMinSum = 0;
    for(int i = 0; i < 1; i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            minSum += arr[i,j];
        }
    }
    for(int i = 1; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            rowSum += arr[i,j];
        }
        if(minSum > rowSum){
            rowWithMinSum = i;
            minSum = rowSum;
            rowSum = 0;
        }
    }
    Console.Write($"The row with minimal sum is {rowWithMinSum}");
}

int n = new Random().Next(3, 4);
int m = new Random().Next(n + 1, n + 3);
int[,] array = GenerateArray(n, m);
PrintArray(array);
Console.WriteLine();
FindMinSum(array);
