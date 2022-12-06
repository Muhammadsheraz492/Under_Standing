// // using System;
// // using FirstProject;
// // using Cal;
// // using Student;
// // namespace Sheraz{
// //     class Program
// //     {

// //         public static void Main(string[] args)
// //         {   
// //             Person person=new Person();
// //             person.Greeting();
// //             int result=Calculator.Add(5,10);
// //             // Student.Student1.Getname();
// //             // Check.Check1
// //             Student1 name=new Student1();
// //             Console.WriteLine(name.Getname());
// //     //   Console.Beep();
// //             // System.Console.WriteLine(result);
// //             Calculator Check=new Calculator();
// //             Check.a=7;
// //             Check.b=7;
// //             System.Console.WriteLine(name);
// //             System.Console.WriteLine(Check.Square());
// //             System.Console.WriteLine("Hello world");
// //         }
// //     }

// // // }
// using Weigh;
// namespace MAin
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             // Income Ali=new Income();
//             System.Console.Write("Enter Wage of per hours (in Dollars please):");
//             Int16 wage = Convert.ToInt16(System.Console.ReadLine());
//             System.Console.Write("Enter hours:");
//             Int16 hours = Convert.ToInt16(System.Console.ReadLine());
//             Int64 result = Income.Check(wage,hours);
//             System.Console.WriteLine(result+" $");
//             // System.Console.WriteLine(typeof(result));

//             // System.Console.WriteLine(System.typeof(System.Console.ReadLine()));

//             // Int64 result=Ali.(500,25);
//             //  Income.Calculate();        
//         }
//     }

// }




// Leacture 3 Today date is 5:55pm


// 1)Expolist type Cast
// 2)Break Points
// 3)Constructor    
// 4)destructor
// Pratice 
// Constructor overloading
// Method overloading

// Same functions can not be declared but if parameter are not same then you can create the two functions with the same name 




// First Quz 
using Student;
namespace Program
{
    public class MyClass
    { 
        public static void Main(string[] args)
        {
            Student1 Ali=new Student1();
            System.Console.Write("Enter you'r Name:");
            String Name=System.Console.ReadLine();
            Ali.SetName(Name);
             System.Console.Write("Enter you'r Roll Number:");
            String Roll_numer=System.Console.ReadLine();
            Ali.SetRoll_name(Roll_numer);
             System.Console.Write("Enter you'r Number of Skill:");
            Int64 Skill=Convert.ToInt64(System.Console.ReadLine());
            Ali.SetSkill(Skill);
             System.Console.Write("Enter you'r Cgpa:");

            Double CgpA=Convert.ToDouble(System.Console.ReadLine());
            Ali.SetCGpa(CgpA);
            System.Console.Write("\n\n\n");
            Ali.Print();
            
            

            
        }
        
    }
    
}
















