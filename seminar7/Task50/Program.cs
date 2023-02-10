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
int n = new Random().Next(3, 4);
int m = new Random().Next(3, 4);
int[,] array = GenerateArray(n, m);
PrintArray(array);
Console.WriteLine("Please enter position of element ");
int[] position = Console.ReadLine().Split(" ").Select(p => int.Parse(p)).ToArray();
if(position[0] >= array.GetLength(0) || position[1] >= array.GetLength(1) 
                                     || position[0] < 0 || position[1] < 0){
    Console.WriteLine("There is no element on chosen position.");
}else{
    int element = array[position[0], position[1]];
    Console.WriteLine($"The element on position ({position[0]}, {position[1]}) equals {element}");
}
