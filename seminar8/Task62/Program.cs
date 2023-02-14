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
    int val = 1;
    int rowInd = 0;
    int colInd = 0;
    for(int i = 0; i < n/2; i++){

            while(colInd < m-i){
                arr[rowInd,colInd] = val;
                val++;
                colInd++;              
            }
            colInd--;
            rowInd++;
            
            while(rowInd < n-i){
                arr[rowInd, colInd] = val;
                val++;
                rowInd ++;
            }
            rowInd--;
            while(colInd > i){
                arr[rowInd, colInd-1] = val;
                val++;
                colInd--;
            }
            while (rowInd>i+1)
            {
                arr[rowInd-1, colInd] = val;
                val++;
                rowInd--;
            }
            colInd++;

    }
    if(n%2 != 0){
        int index = n/2;
        arr[index,index] = val;
    }
    return arr;
}
int n = new Random().Next(4,5);
int[,] array = GenerateArray(n, n);
PrintArray(array);
