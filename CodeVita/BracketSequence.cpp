#include<iostream>
#include<string>
#include<algorithm>
using namespace std;

int main()
{
	string s;
	std::cin>>s;
	// check if string is even with equal no of ( and )
	if(s.length()%2 != 0 || std::count(s.begin(),s.end(),'(')!=std::count(s.begin(),s.end(),')'))
	{
		std::cout<<0;
		return 0;
	}
	int arr[s.length()];
	int sum=0;
	
	// create an array with +1 and -1 values and find the PrefixSum value for each element
	for(int i=0;i<s.length();i++)
	{
		if(s[i]=='(')
			sum++;
		else
			sum--;
		arr[i] = sum;
	}
	int min = 9999999999999;
	
	// Find the prefix value which is the minimum
	
	for(int i=0;i<s.length();i++)
	{
		if(min>arr[i])
			min = arr[i];
		else
			continue;
	}
	int count = 0;
	
	// The count of the most minimum value is our answer
	
	for(int i=0;i<s.length();i++)
	{
		if(arr[i]==min)
			count++;
	}
	std::cout<<count;
	return 0;
}
