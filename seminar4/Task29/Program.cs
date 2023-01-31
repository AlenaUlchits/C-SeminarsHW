int[] createAndPrintArrayValues(int size){
    int[] array = new int[size];
    for(int i = 0 ; i < size; i++){
        array[i] = new Random().Next(-9, 10);
        Console.Write(array[i] + ", ");
    }
    return array;
}
void printArray(int[] arr){
    Console.Write("[" + string.Join(", ", arr) + "]");
}
Console.WriteLine("Enter a size of array ");
int size = int.Parse(Console.ReadLine());

int[] array = createAndPrintArrayValues(size);
Console.Write("\b\b-> ");
printArray(array);


