#include<iostream>
#include<bits/stdc++.h>
using namespace std;

int main()
{
	int i_TestCases;
	std::cin>>i_TestCases;
	while(i_TestCases!=0)
	{
		i_TestCases--;
		
		int i_sizeOfarray,x;
		std::cin>>i_sizeOfarray;
		int *resultArr = (int *)malloc(i_sizeOfarray*sizeof(int));
		int *check = (int *)calloc(3,sizeof(int));
		
		for(int i=0;i<i_sizeOfarray;i++)
		{
			std::cin>>x;
			*(resultArr+i) = x%3;
		}
		
		for(int i=0;i<i_sizeOfarray;i++)
		{
			if(*(resultArr+i)==0)
				*(check+0) += 1;
			else if(*(resultArr+i)==1)
				*(check+1) += 1;
			else if(*(resultArr+i)==2)
				*(check+2) += 1;				
		}
		
		free(resultArr);
		resultArr = NULL;
		
		if((*(check)==0) && *(check+2)==0 && *(check+1)!=0)
			std::cout<<"Yes";
		else if( *(check+0)==0 && *(check+1)==0 && *(check+2)!=0)
			std::cout<<"Yes";
		else if((*(check)==0) && *(check+2)!=0 && *(check+1)!=0)
			std::cout<<"No";
		else if(*(check) <= (*(check+1)+*(check+2)+1))
			std::cout<<"Yes";
		else
			std::cout<<"No";
		
		free(check);
		check = NULL;
		
		return 0;
	}
	
}
