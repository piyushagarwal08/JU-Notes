// 3 Pallindrom
#include<iostream>
#include<string>
using namespace std;

bool Pallindrome(string s_input)
{
	int string_length = s_input.length();
	if (string_length == 1)
		return true;
	for(int data=0;data<string_length/2;data++)
	{
		if(s_input[data] != s_input[string_length-(data+1)])
			return false;
	}
	return true;
}

int main()
{
	string s_input;
	std::cin>>s_input;
  	int n = s_input.length()-2;
	for(int i=1;i<n;i++)
	{
		if (Pallindrome(s_input.substr(0,i)))
		{
			for(int j=i+1;j<n+2;j++)
			{
				if(Pallindrome(s_input.substr(i,j-i)) && Pallindrome(s_input.substr(j,s_input.length()-j+1)))
				{
					std::cout<<s_input.substr(0,i)<<endl;
					std::cout<<s_input.substr(i,j-i)<<endl;
					std::cout<<s_input.substr(j,s_input.length()-j+1)<<endl;
					return 0;
				}
			}
		}
	}
	std::cout<<"Not possible";
	return 0;
}


