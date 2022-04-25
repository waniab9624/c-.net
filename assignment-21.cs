using System;
namespace CSharp_Shell
{
    public class Program 
    {
	void get(int x)
	{
	x=10;
	Console.WriteLine(x);
	}
        public static void Main()
        {
	int x=20;
			Program p=new Program();
			Console.WriteLine("before function call:-"+x);
			p.get(x);
			Console.WriteLine("after function call:-"+x);
            Console.ReadLine();
        }    }}




