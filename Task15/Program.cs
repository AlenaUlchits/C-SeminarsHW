void showDayOfWeek(int weekNum){
    switch(weekNum){
        case 1:
        Console.WriteLine("Monday");
        break;
        case 2:
        Console.WriteLine("Tuesday");
        break;
        case 3:
        Console.WriteLine("Wednesday");
        break;
        case 4:
        Console.WriteLine("Thursday");
        break;
        case 5:
        Console.WriteLine("Friday");
        break;
        case 6:
        Console.WriteLine("Saturday");
        break;
        case 0:
        Console.WriteLine("Sunday");
        break;
        default:
        break;
    }
}
Console.Write("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int numberOfWeek = num % 7;
showDayOfWeek(numberOfWeek);
