void FindDot(double[] firstFunctionCoef, double[] secondFunctionCoef){
    double x = (secondFunctionCoef[0] - firstFunctionCoef[0])/(firstFunctionCoef[1]-secondFunctionCoef[1]);
    double y = firstFunctionCoef[1] * x + firstFunctionCoef[0];
    Console.WriteLine($"({Math.Round(x, 2)}, {Math.Round(y, 2)})");
}
Console.WriteLine("Enter 2 coefficients of the first function ");
double[] firstCoef = Console.ReadLine().Split(" ")
                         .Select(c=>Convert.ToDouble(c))
                         .ToArray();
Console.WriteLine("Enter 2 coefficients of the second function ");
double[] secondCoef = Console.ReadLine().Split(" ")
                         .Select(c=>Convert.ToDouble(c))
                         .ToArray();
Console.Write($"b1 = {firstCoef[0]}, k1 = {firstCoef[1]}, b2 = {secondCoef[0]}, k2 = {secondCoef[1]} ->");
FindDot(firstCoef, secondCoef);