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
int FindDiffBetwenMaxAndMin(int[] array){
    int indexMin = 0;
    int indexMax = 0;
    for(int i = 1; i < array.Length; i++){
        if(array[indexMax] < array[i]){
            indexMax = i;
        }else if(array[indexMin] > array[i]){
            indexMin = i;
        }
    }
    int diff = array[indexMax] - array[indexMin];
    return diff;
}
Console.WriteLine("Enter an array size ");
int size = int.Parse(Console.ReadLine());
int[] arr = GenerateArray(size);
PrintArray(arr);
Console.Write("-> ");
Console.Write(FindDiffBetwenMaxAndMin(arr));
