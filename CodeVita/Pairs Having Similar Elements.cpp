// Pairs Having Similar Elements
#include<iostream>
#include<map>
#include<iterator>
using namespace std;

int main()
{
	int n=8;
	int a[n] = {1,3,5,7,8,2,5,7};
	map<int,int> map1;
	for(int i=0;i<n;i++)
	{
		for(int j=i+1;j<n;j++)
		{
			if(a[i]==a[j]+1 || a[i] == a[j]-1)
			{
				map1.insert({a[i],a[j]});
			}
		}
	}
	int count= map1.size();
	map<int,int> :: iterator itr;
	for(itr=map1.begin();itr != map1.end();++itr)
	{
		if(map1.find(itr->second) != map1.end())
			count++;
	}
	
	std::cout<<count;
	return 0;
}	
