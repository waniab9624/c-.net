using System;
namespace CSharp_Shell
{
  public class Program 
   {
int r;
  String n;
Program(int rollno,string name)
     {
r = rollno;
n=name;
Console.WriteLine(r+"\t"+n);
  }
Program()
      {
Console.WriteLine("Constructor called");
      }
public static void Main(string [] args)
{
	Program p=new Program();
Program p1= new Program(107,"abhay");
Console.ReadLine();
	}
      }
 }





