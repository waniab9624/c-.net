using System;
namespace ConsoleApplication
{
 public class Program 
    {
 public static void Main()
   {
try
	{
	int a=2;
	int b=0;
	int c=a/b;
	Console.WriteLine(c);
	}
catch(Exception e)
	{
	Console.WriteLine("Exception occurred:-"+e);
	}
finally
	{
	Console.WriteLine("Exception handled");
    Console.ReadLine();
    
	}       
 }
    
 }

}






