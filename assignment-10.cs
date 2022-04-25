using System;
namespace  CSharp_Shell
{
    public class Program 
    {
        public static void Main()
        {
			int i =1,n;

			Console.WriteLine("Enter a number:-");

		n=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("seris of 1 to 10 in for loop:-");
		while(i<=n)
		    {
			Console.WriteLine(i);
			i++;
		    }
		Console.ReadLine();
        }    }}

