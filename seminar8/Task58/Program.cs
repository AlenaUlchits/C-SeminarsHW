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
            arr[i,j] = new Random().Next(0, 5);
        }
    }
    return arr;
}
int[,] FindProduct(int[,] matrixA, int[,] matrixB){
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    
    for(int row = 0; row < matrixA.GetLength(0); row ++){
        for (int col = 0; col < matrixB.GetLength(1); col++)
        {
            for(int colMatA = 0; colMatA < matrixA.GetLength(1); colMatA++){
                result[row,col] += matrixA[row, colMatA] * matrixB[colMatA, col];
            }
        }
    }
    return result;
}
int n = new Random().Next(3, 6);
int m = new Random().Next(3, 6);
int[,] array1 = GenerateArray(n, m);
n = new Random().Next(3, 6);
m = new Random().Next(3, 6);
int[,] array2 = GenerateArray(n, m);
Console.WriteLine("The first matrix: ");
PrintArray(array1);
Console.WriteLine("The second matrix: ");
PrintArray(array2);
if(array1.GetLength(1) == array2.GetLength(0)){
    Console.WriteLine("The product of matrixes");
    PrintArray(FindProduct(array1, array2));
}else{
    Console.WriteLine("Not possible to find product.");
}
