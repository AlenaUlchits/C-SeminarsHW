int[] GenerateArray(int size){
    int[] arr = new int[size];
    for(int i = 0; i< arr.Length; i++){
        arr[i] = new Random().Next(-8, 9);
    }
    return arr;
}
void PrintArray(int[] arr){
    Console.Write("[ ");
    for(int i = 0; i< arr.Length; i++){

        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b] ");
}
int FindSum(int[] array){
    int sum = 0;
    for(int i = 0; i < array.Length; i++){
        if(i %  2 != 0){
            sum += array[i];
        }
    }
    return sum;
}
Console.WriteLine("Enter an array size ");
int size = int.Parse(Console.ReadLine());
int[] arr = GenerateArray(size);
PrintArray(arr);
Console.Write("-> ");
Console.Write(FindSum(arr));
