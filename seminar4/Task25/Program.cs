void Exponentiation(int numToExponent, int degree){
    int result = 1;
    for(int i = 0; i < degree; i++){
        result *= numToExponent;
    }
    Console.WriteLine($"{numToExponent}, {degree} -> {result} ({numToExponent}^{degree})");
    Console.WriteLine("{0}, {1} -> {2} ({0}^{1})", numToExponent, degree, Math.Pow(numToExponent,degree));
}
Console.WriteLine("Enter two numbers ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Exponentiation(num1, num2);

