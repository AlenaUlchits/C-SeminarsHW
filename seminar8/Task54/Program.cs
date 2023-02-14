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

void SortElements(int[,] arr, string sortingType){
    switch(sortingType){
        case "DESC":
        int temp;
            for(int i = 0; i < arr.GetLength(0); i++){
                for(int j = 0; j < arr.GetLength(1); j++){
                    for(int k = 0; k < arr.GetLength(1)-1; k++){
                        if(arr[i,k] < arr[i, k + 1]){
                            temp = arr[i,k];
                            arr[i,k] = arr[i,k+1];
                            arr[i,k+1] = temp;

                        }
                    }
                }
            }
            break;
        default:
        for(int i = 0; i < arr.GetLength(0); i++){
                for(int j = 0; j < arr.GetLength(1); j++){
                    for(int k = 0; k < arr.GetLength(1)-1; k++){
                        if(arr[i,k] > arr[i, k + 1]){
                            temp = arr[i,k];
                            arr[i,k] = arr[i,k+1];
                            arr[i,k+1] = temp;
                        }
                    } 
                }
            }
        break;
    }

}
int n = new Random().Next(3, 6);
int m = new Random().Next(3, 6);
int[,] array = GenerateArray(n, m);
PrintArray(array);
Console.WriteLine();
SortElements(array, "DESC");
PrintArray(array);
