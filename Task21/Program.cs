void findDistance(string[] dotA, string[] dotB){
    int x1 = Convert.ToInt32(dotA[0]), y1 = Convert.ToInt32(dotA[1]), z1 = Convert.ToInt32(dotA[2]);
    int x2 = Convert.ToInt32(dotB[0]), y2 = Convert.ToInt32(dotB[1]), z2 = Convert.ToInt32(dotB[2]);
    double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
    Console.WriteLine("The distnce brtwen A({0},{1},{2}) and B({3},{4},{5}) equals {6}", x1, y1, z1, x2, y2, z2, Math.Round(d, 2));
}

Console.WriteLine("Enter coordinates of dote A for 3D space");
string[] dotA = Console.ReadLine().Split(" ");

Console.WriteLine("Enter coordinates of dote B for 3D space");
string[] dotB = Console.ReadLine().Split(" ");
findDistance(dotA, dotB);


