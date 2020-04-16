/*
// Sample code to perform I/O:
#include <stdio.h>

int main(){
	int num;
	scanf("%d", &num);              			// Reading input from STDIN
	printf("Input number is %d.\n", num);       // Writing output to STDOUT
}

// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
*/

// Write your code here
#include<stdio.h>
#include<stdlib.h>
#include<math.h>

int BitAnd(int *a,int n)
{
	int v_and;
	for(int i=0;i<n;i++)
		v_and = a[i] & a[i+1];
	return v_and;
}

int BitOr(int *a,int n)
{
	int v_or;
	for(int i=0;i<n;i++)
		v_or = a[i] ^ a[i+1];
	return v_or;
}

int BitXor(int *a,int n)
{
	int v_xor;
	for(int i=0;i<n;i++)
		v_xor = a[i] & a[i+1];
	return v_xor;
}

int main()
{
	int n,i=0,count=0;
	scanf("%d",&n);
	int *a = (int * )malloc(sizeof(n));
	while(i<n)
	{
		scanf("%d",&a[i]);
		i++;
	}
	i=1;
	while(i<n)
	{	
		int *arr = (int * )malloc(sizeof(i));
		for(int j=0;j<i;j++)
			arr[j] = a[j];
		int x = BitAnd(arr,i);
		int y = BitOr(arr,i);
		int z = BitXor(arr,i);
		if (x==y==z)
		{
			count++;
		}
		++i;
	}
	int answer = ((int)pow(10,9)+7)%(int)count;
	printf("%d",answer+7);
	//printf("%d",answer);
	
	
	return;
}/*
// Sample code to perform I/O:
#include <stdio.h>

int main(){
	int num;
	scanf("%d", &num);              			// Reading input from STDIN
	printf("Input number is %d.\n", num);       // Writing output to STDOUT
}

// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
*/

// Write your code here
#include<stdio.h>
#include<stdlib.h>
#include<math.h>

int BitAnd(int *a,int n)
{
	int v_and;
	for(int i=0;i<n;i++)
		v_and = a[i] & a[i+1];
	return v_and;
}

int BitOr(int *a,int n)
{
	int v_or;
	for(int i=0;i<n;i++)
		v_or = a[i] ^ a[i+1];
	return v_or;
}

int BitXor(int *a,int n)
{
	int v_xor;
	for(int i=0;i<n;i++)
		v_xor = a[i] & a[i+1];
	return v_xor;
}

int main()
{
	int n,i=0,count=0;
	scanf("%d",&n);
	int *a = (int * )malloc(sizeof(n));
	while(i<n)
	{
		scanf("%d",&a[i]);
		i++;
	}
	i=1;
	while(i<n)
	{	
		int *arr = (int * )malloc(sizeof(i));
		for(int j=0;j<i;j++)
			arr[j] = a[j];
		int x = BitAnd(arr,i);
		int y = BitOr(arr,i);
		int z = BitXor(arr,i);
		if (x==y==z)
		{
			count++;
		}
		++i;
	}
	int answer = (int)count/((int)pow(10,9)+7);
	printf("%d",answer+7);
	//printf("%d",answer);
	
	
	return 0;
}