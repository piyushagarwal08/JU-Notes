// Micro and Array Update

#include<iostream>
using namespace std;

int main()
{
	int T;
	std::cin>>T;
	while(T>0)
	{
		T--;
		int N,K;
		std::cin>>N>>K;
		int x,min=999999999;
		for(int i=0;i<N;i++)
		{
				std::cin>>x;
				if(min>x)
					min=x;
		}
		if(min<K)
			std::cout<<K-min<<endl;
		else
			std::cout<<0<<endl;
	}
	return 0;
}
