void isWeekend(int weekNum){
    switch(weekNum){
        case 1:
        Console.WriteLine("No");
        break;
        case 2:
        Console.WriteLine("No");
        break;
        case 3:
        Console.WriteLine("No");
        break;
        case 4:
        Console.WriteLine("No");
        break;
        case 5:
        Console.WriteLine("No");
        break;
        case 6:
        Console.WriteLine("Yes");
        break;
        case 0:
        Console.WriteLine("Yes");
        break;
        default:
        break;
    }
}
Console.Write("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int numberOfWeek = num % 7;
isWeekend(numberOfWeek);
