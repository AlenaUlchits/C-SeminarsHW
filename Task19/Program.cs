Boolean checkIsPalindrome(string number){
    Boolean isPalindrome = false;
    int lastIndex = number.Length - 1;
    for(int i = 0; i < number.Length/2; i++){
        if(number[i] == number[lastIndex-i]){
            isPalindrome = true;
        }else{
            isPalindrome = false;
            break;
        }
    }
    return isPalindrome;
}
Console.Write("Enter a number ");
string num = Console.ReadLine();
Boolean isPalindrome = checkIsPalindrome(num);
if(isPalindrome){
    Console.WriteLine("The number {0} is a palindrome.", num);
}else{
    Console.WriteLine("The number {0} is not a palindrome.", num);
}
