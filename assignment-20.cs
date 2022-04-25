using System;
namespace CSharp_Shell
{
    public static class Program 
    {
        public static void Main()
        {
int [] a={12,34,56,78,89};
int i ,max,min;
           max=a[0];
           min=a[0];
for(i=1;i<5;i++)
           {
if(a[i]>max)
           {
	max=a[i];
           }

if(a[i]<min)
           {
	min=a[i];
           }
           }
Console.WriteLine("maximum number:-"+max);
Console.WriteLine("minimum number:-"+min);
Console.ReadLine();

        }
    }
}



