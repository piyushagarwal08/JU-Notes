#include<iostream>
#include<string>
using namespace std;

int main()
{
    string s = "abbdab";
    int n = s.length();
    string res = "#";
    for(int i=0;i<n;i++)
    {
        res+=std::string(1,s[i])+'#';
    }
    
}