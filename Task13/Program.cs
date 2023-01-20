void getThirdDigit(string source){
    source.Substring(0,3);
    Console.WriteLine(source[2]);
}

Console.Write("Enter a number ");
string num = Console.ReadLine();
if(num != null && num.Length < 3){
    Console.WriteLine("There is no 3rd digit!");
}else{
    getThirdDigit(num);
}
