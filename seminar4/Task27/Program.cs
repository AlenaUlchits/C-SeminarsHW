int countDigitSum(int num){
    int sum = 0;
    int[] digits = num.ToString().Select(d=>Convert.ToInt32(d) -48).ToArray();
    foreach(int digit in digits){
        sum += digit;
    }
    return sum;
}
Console.WriteLine("Enter a number ");
int num = int.Parse(Console.ReadLine());
int sum = countDigitSum(num);
Console.WriteLine($"{num} -> {sum}");
