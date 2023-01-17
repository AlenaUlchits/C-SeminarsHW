Console.Write("Enter two numbers ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
//First method
if(num1 > num2){
    Console.WriteLine("{0} is max", num1);
}else if(num2 > num1){
    Console.WriteLine("{0} is max", num2);
}else{
    Console.WriteLine("Numbers are equal");
}
//Second method
Console.WriteLine("Max is {0}",Math.Max(num1,num2));
