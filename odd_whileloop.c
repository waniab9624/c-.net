#include<stdio.h>
int main()
{
	int i,sum=0;
	
	i=1;
	while(i<=100)
	{
		if(i%2==0)
		sum = sum + i;
		printf("\n%d",i);
		i=i+2;
	}
}
