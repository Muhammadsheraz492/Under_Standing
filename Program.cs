using System;
using FirstProject;
using Cal;
    

    class Program
    {
 
        public static void Main(string[] args)
        {   
            Person person=new Person();
            person.Greeting();
            int result=Calculator.Add(5,10);
            System.Console.WriteLine(result);
            System.Console.WriteLine("Hello world");
        }
    }

