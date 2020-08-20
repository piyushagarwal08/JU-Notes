# Data Structures

# 1-D Arrays

```cpp
// Print Array in Reverse
#include<iostream>
using namespace std;
int main()
{


int N;
std::cin>>N;
int a[N];
for(int i=0;i<N;i++)
    std::cin>>a[i];
for(int i=N-1;i>=0;i--)
    std::cout<<a[i]<<endl;

return 0;
}
```

```cpp
// Bracket Sequences
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
```

```cpp
// Micro and Array Update
#include<iostream>
#include<bits/stdc++.h>
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
		int x,min=INT_MAX;
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
```

