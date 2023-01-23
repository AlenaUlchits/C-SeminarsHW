Console.WriteLine("Enter a number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> ");
for(int i = 1; i <= num; i++){
   Console.Write($"{Math.Pow(i, 3)}, "); 
}
Console.Write("\b\b. ");
