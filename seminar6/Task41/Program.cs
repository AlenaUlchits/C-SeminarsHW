void CountEvenNumbers(int[] array){
    int count = 0;
    for(int i = 0; i< array.Length; i++){
        if(array[i] > 0){
            count++;
        }
    }
    Console.Write(count);
}
void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b-> ");
}
Console.WriteLine("Enter numbers as much as you want ");
int[] arr = Console.ReadLine().Split(" ")
                    .Select(n => Convert.ToInt32(n))
                    .ToArray();
PrintArray(arr);
CountEvenNumbers(arr);
