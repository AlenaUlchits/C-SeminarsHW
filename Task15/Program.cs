void isWeekend(int weekNum){
   if(weekNum == 6 || weekNum == 0){
    Console.WriteLine("It is a weekend");
   }else{
    Console.WriteLine("It is not a weekend");
   }
}
Console.Write("Enter a number ");
int num = Convert.ToInt32(Console.ReadLine());
int numberOfWeek = num % 7;
isWeekend(numberOfWeek);
