using System.Globalization;
namespace Student{
   public class Student1
    { 
     String name,Roll_numer;
     Int64 Number_Skill;
     Double CgpA;
    //  Array Skill;

    // Student1(){

    // }
    public void SetName(String name){
     this.name=name;
    }
     public void SetRoll_name(String Roll_numer){
     this.Roll_numer=Roll_numer;
    }
     public void SetSkill(Int64 Number_Skill){
     this.Number_Skill=Number_Skill;
    }
     public void SetCGpa(double CgpA){
     this.CgpA=CgpA;
    }
    public void Print(){
      System.Console.WriteLine("You'r Name is :"+this.name);
      System.Console.WriteLine("You'r Roll Number is :"+this.Roll_numer);
      System.Console.WriteLine("You'r Skills is:"+this.Number_Skill);
      System.Console.WriteLine("You'r Cgpa is:"+this.CgpA);

    }
    //  Int64 ;
      

        
    }
}