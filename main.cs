using System;

class MainClass {
  public static void Main (string[] args) {
    
    //prompt to enter #'s
    Console.WriteLine("Enter firt number: ");
    var num1 = Console.ReadLine();
    Console.WriteLine("Enter second number: ");
    var num2 = Console.ReadLine();
    
    //convert #'s from string to int for addition
    int numb1 = Convert.ToInt32(num1);
    int numb2 = Convert.ToInt32(num2);

    //add both converted #'s and store them as sum
    int sum = (numb1+numb2);
    Console.WriteLine("Sum = " +sum);

    //subtract num2 from num1
    int diff = (numb1-numb2);
    Console.WriteLine("Diff = " +diff);
    
    //multiply number 1 by number 2
    int product = (numb1*numb2);
    Console.WriteLine("Product = " +product);

    //divide number 1 by number 2
    int quotient = (numb1/numb2);
    Console.WriteLine("Quotient = " +quotient);

    //Find the remainder
    int remainder = (numb1%numb2);
    Console.WriteLine("Remainder = " +remainder);







   
  }
}