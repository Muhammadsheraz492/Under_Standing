using System;

namespace First
{
    public class Person{
        public void Greeting(){
            System.Console.WriteLine("Tested  Person");
        }
    }


    class Program
    {
 
        public static void Main(string[] args)
        {   
            Person person=new Person();
            person.Greeting();
            System.Console.WriteLine("Hello world");
        }
    }

}