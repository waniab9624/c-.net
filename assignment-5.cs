using System;

namespace  ConsoleApplication8{
public class Program 
    {
    public	int rollno=107;
     public string name= "Abhay";
    }
    class  exam: Program
    {
  public static void Main()
        {
	exam n=new exam();
Console.WriteLine(n.rollno);
Console.WriteLine( n.name);
	Console.ReadLine();
        }
    }
}
