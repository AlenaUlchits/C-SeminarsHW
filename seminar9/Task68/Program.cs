int Ackermann(int m, int n){
    if(m==0){
        return n +1;
    }else if(m > 0 && n==0){
        return Ackermann(m-1,1);
    }else{
        return Ackermann(m-1, Ackermann(m, n-1));
    }

}
int m = new Random().Next(0,4);
int n = new Random().Next(0,11);
if(m < 0 || n < 0){
    Console.WriteLine($"Not possible to find A({m},{n})");
}else{
    int result = Ackermann(m,n); 
  Console.WriteLine($"A({m},{n}) -> {result}");  
}

