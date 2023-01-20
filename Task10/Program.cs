void findSecondNumber(string source){
char[] arr = source.ToCharArray();
Console.WriteLine(arr[1]);
}
Console.WriteLine("Enter a number ");
string num = Console.ReadLine();
if(num != null && num.Length == 3){
    findSecondNumber(num);
}else{
    Console.WriteLine("The number doesn't contain 3 charcters");
}

