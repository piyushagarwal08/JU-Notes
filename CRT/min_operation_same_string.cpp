/* Minimum no of operations to make two string same using recursion
Complexity: 3^n

#include<string>
#include<iostream>
using namespace std;
int FindCost(string X,string Y,int m,int n)
{
    if(m==0)
        return n;
    if(n==0)
        return m;
    int cost;
    if(X[m-1]==Y[n-1])
        cost =0;
    else
        cost = 1;
    // replace+1,insert+1,substitue +1
    return min(min(FindCost(X,Y,m-1,n)+1,FindCost(X,Y,m,n-1)+1),FindCost(X,Y,m-1,n-1)+cost);
    // complexity 3^n
}
int main()
{
    string X="kitten",Y="sitting";
    std::cout<<FindCost(X,Y,X.length(),Y.length());
    return 0;
}
*/
