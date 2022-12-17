using System;
using System.Collections.Generic;

public  class Program 
{
    
    public static void Main(string[] args)
    {
         List<int> FoundNumbers=new List<int>();
         int num1,num2,PerfectOrPrime;
        Console.WriteLine ("Enter first number");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter last number");
        num2=int.Parse(Console.ReadLine());

        if(num2<=1 || num1<=1) {
           Console.WriteLine("Invaild Input!!...The both numbers must be larger than 1");
        return;
        }
      else if(num2<=num1) {
            Console.WriteLine("Invaild Input!!...The second number must be larger than the first");
            return;
        }
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Enter your operation NUMBER:\n  1 => Prime **** 2 => Perfect");
    Console.ForegroundColor = ConsoleColor.White;
    PerfectOrPrime=int.Parse(Console.ReadLine());
 while (PerfectOrPrime!=1 && PerfectOrPrime!=2){
    Console.WriteLine("Invaild Input!!....Please type valid operation");
    PerfectOrPrime=int.Parse(Console.ReadLine());
}

  if(PerfectOrPrime==1) IsPrime(FoundNumbers ,num1, num2);
   else if(PerfectOrPrime==2) IsPerfect(FoundNumbers ,num1, num2);
        PrintList(FoundNumbers,PerfectOrPrime);
        Console.ForegroundColor = ConsoleColor.White;
       return;
    }

 public static void IsPrime(List<int> PrimeNumbers,int num1,int num2,int sum=0){
        for(int n=num1; n <num2; n++ ){
            for(int counter=2;counter<n;counter++){
                if(n%counter==0) sum+=counter;
            }
            if(sum==0) {
                PrimeNumbers.Add(n);
                
            }
            sum=0;
        }   
    }

public static void IsPerfect(List<int> PerfectNumbers,int num1,int num2,int sum=0){
        for(int n=num1; n <num2; n++ ){
            for(int counter=1;counter<n;counter++){
                if(n%counter==0) sum+=counter;
            }
            if(sum==n) {
                PerfectNumbers.Add(n);
                
            }
            sum=0;
        }   
    }
        
    public static void PrintList(List<int> Numbers,int Op){
        if(Numbers.Count==0) {
            Console.ForegroundColor = ConsoleColor.Red;
             Console.Write("Numbers found: Nothing :'(");
             return;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        if(Op==1)    Console.WriteLine("Found {0} Prime Numbers :)",Numbers.Count);
        else if(Op==2)   Console.WriteLine("Found {0} Perfect Numbers :)",Numbers.Count);
        Console.Write("Numbers found: ");
        for(int i=0; i<Numbers.Count;i++){
            Console.Write(Numbers[i]+", ");
        }
        return;
    }
    }
