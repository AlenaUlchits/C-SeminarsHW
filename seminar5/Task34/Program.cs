int[] GenerateArray(int size){
    int[] arr = new int[size];
    for(int i = 0; i< arr.Length; i++){
        arr[i] = new Random().Next(100, 1000);
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
int FindEvenQuantity(int[] array){
    int count = 0;
    foreach(int num in array){
        if(num % 2 == 0){
            count++;
        }
    }
    return count;
}
Console.WriteLine("Enter an array size ");
int size = int.Parse(Console.ReadLine());
int[] arr = GenerateArray(size);
PrintArray(arr);
Console.Write("-> ");
Console.Write(FindEvenQuantity(arr));
