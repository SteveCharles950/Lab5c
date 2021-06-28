using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a whole number");
    var x = Console.ReadLine();
    int x1 = Convert.ToInt32(x);
    //int remainder=0;
    int state = 0;
    
    
    for (int i=2; i<x1/2; i++)
    {
      //remainder = x1 % x1;

      if (x1%i == 0)
      {
        Console.WriteLine (x1 + " is a non-prime number");
        state =1;
        break;
      }
    }
      if(state == 0){               
        Console.WriteLine (x1 + " is a prime number");
     
      }
    } 
  }