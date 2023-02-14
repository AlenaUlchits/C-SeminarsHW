int FindSum(int min, int max, int sum){
    if(min == max){
        sum += min;
        return sum;
    }else{
        sum +=min;
       return FindSum(min+1, max, sum);
    }
}
int min = new Random().Next(1,15);
int max = new Random().Next(min+1,30);
int sum = 0;
Console.WriteLine($"Sum between {min} and {max} equals {FindSum(min,max, sum)}");
