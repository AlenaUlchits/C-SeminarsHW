void PrintArray(int[,,] array){
    for(int i = 0; i < array.GetLength(2); i++){
        for(int j = 0; j < array.GetLength(0); j++){
          for(int k = 0; k < array.GetLength(1); k++){  
            Console.Write($"{array[j, k, i]} ({j}, {k}, {i}) \t");
          }
          Console.WriteLine();
        }
        
    }
}
int[,,] GenerateArray(int row, int col, int lev){
    int[,,] arr = new int[row, col, lev];
    int minElem =  new Random().Next(10, 50);
    for(int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for(int l = 0; l < arr.GetLength(2); l++){
                arr[i,j,l] = minElem + l;
                minElem ++;
            }
        }
    }
    return arr;
}

int row = new Random().Next(2, 4);
int col = new Random().Next(2, 4);
int lev = new Random().Next(2, 4);
int[,,] array = GenerateArray(row, col, lev);
PrintArray(array);
