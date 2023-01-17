//First and second variants are more preferable, because they can be modified
//First variant
/*
Console.Write("Enter three numbers ");
int[] numbers = new int[3];
for(int i = 0; i<numbers.Length; i++){
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("The max value is {0}", numbers.Max());*/

//Second variant
/*
Console.Write("Enter three numbers ");
int[] numbers = new int[3];
for(int i = 0; i<numbers.Length; i++){
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int max = numbers[0];
for(int i = 1; i<numbers.Length; i++){
    if(max<numbers[i]){
        max = numbers[i];
    }
}
Console.WriteLine("The max value is {0}", max);*/

//Third variant (as we don't need to display all numbers will consider that the first entered number is max)
Console.Write("Enter three numbers ");
int max = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if(max < num2){
    max = num2;
}else if(max < num3){
    max = num3;
}
Console.WriteLine("The max value is {0}", max);



