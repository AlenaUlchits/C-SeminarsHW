double[,] GenerateMatrix(int rows, int cols){
    double[,] matrix = new double[rows, cols];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = Math.Round(((new Random().NextDouble() * 10) - 5), 1);  
        }
    }
    return matrix;
}
void PrintArray(double[,] matrix){
     for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j], 7}");
        }
        Console.WriteLine();
    }
}
int n = new Random().Next(3, 5);
int m = new Random().Next(3, 5);
double[,] matrix = GenerateMatrix(n, m);
PrintArray(matrix);
