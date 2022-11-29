using System;
using FirstProject;
using Cal;
using Student;
namespace Sheraz{
    class Program
    {
 
        public static void Main(string[] args)
        {   
            Person person=new Person();
            person.Greeting();
            int result=Calculator.Add(5,10);
            // Student.Student1.Getname();
            // Check.Check1
            Student1 name=new Student1();
            Console.WriteLine(name.Getname());
    //   Console.Beep();
            // System.Console.WriteLine(result);
            Calculator Check=new Calculator();
            Check.a=7;
            Check.b=7;
            System.Console.WriteLine(name);
            System.Console.WriteLine(Check.Square());
            System.Console.WriteLine("Hello world");
        }
    }

}