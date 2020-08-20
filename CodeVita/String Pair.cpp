#include<iostream>
#include<unordered_map>
using namespace std;

int SubSetSum(int *a,int n,int sum)
{
	int T[n+1][sum+1],count=0;
	
	for(int i=1;i<=sum;i++)
		T[0][i] = 0;
	
	for(int i=0;i<=n;i++)
		T[i][0]=1;
		
	for(int i=1;i<=n;i++)
	{
		for(int j=1;j<=sum;j++)
		{
			if(a[i-1]>j)
				T[i][j] = T[i-1][j];
			else
				T[i][j] = T[i-1][j] || T[i-1][j-a[i-1]];
		}
	}
	
	/*
	for(int i=0;i<=n;i++)
	{
		for(int j=0;j<=sum;j++)
			std::cout<<T[i][j]<<" ";
		std::cout<<endl;	
	}*/
	
	for(int i=0;i<=n;i++)
	{
		if(T[i][11] == 1)
			count++;
	}
	
	return count;
}

int main()
{
	unordered_map<int,int>dict1;
	dict1[0] = 2; dict1[1] = 2; dict1[2] = 1; dict1[3] = 2; dict1[4] = 2; dict1[5] = 2; dict1[6] = 1; dict1[7] = 2; dict1[8] = 2; dict1[9] = 2;
	int n,count=0;
	std::cin>>n;
	int *a = (int *)malloc(n*sizeof(int));
	for(int i=0;i<n;i++)
	{
		std::cin>>*(a+i);
	}
	for(int i=0;i<n;i++)
		count += dict1[*(a+i)];
	
	int x = SubSetSum(a,size,sum);
	std::cout<<x;
	
	return 0;
}
