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
void FindAverage(int[,] arr){
    double average = 0;
    for(int i = 0; i < arr.GetLength(1); i++){
        for(int j = 0; j < arr.GetLength(0); j++){
            average += arr[j, i]; 
        }
        average = Math.Round(average/arr.GetLength(1), 2);
        Console.WriteLine($"The average of {i} column equals {average}");
        average = 0;
    }
}
int n = new Random().Next(3, 4);
int m = new Random().Next(3, 4);
int[,] array = GenerateArray(n, m);
PrintArray(array);
FindAverage(array);
