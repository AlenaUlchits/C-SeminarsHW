void PrintNum(int n){
    if(n==1){
        Console.Write($"{n}");
        return;
    }else{
       Console.Write($"{n}, "); 
    }  
    PrintNum(n-1);   
}
int n = new Random().Next(4,30);
Console.Write($"N = {n} -> ");
PrintNum(n);

