// hashing

/*
// find a pair of value whose sum is equal to 10

#include<iostream>
#include<unordered_map>
using namespace std;

void FindPair(int *a,int n,int sum)
{
    unordered_map<int,int>map;
    for(int i=0;i<n;i++)
    {
        if(map.find(sum-a[i])!= map.end())
        {
            cout<<"Pair Found at Index: "<<map[sum-a[i]]<<" "<<i<<endl;
            break;
        }
        map[a[i]] = i;
    }
}

int main()
{
    int a[] = {8,7,2,5,3,1};
    int n = sizeof(a)/sizeof(a[0]);
    int sum = 10;
    FindPair(a,n,sum);
}
*/

/*
#include<iostream>
#include<unordered_set>
using namespace std;
int ZeroSum(int *a,int n)
{
    unordered_set<int>set;
    set.insert(0);
    int sum=0;
    for(int i=0;i<n;i++)
    {
        sum+=a[i];
        if(set.find(sum)!= set.end()) // complexity to search key is O(1)
        {
            return 1;
        }
        set.insert(sum);
    }
    return 0;
}
int main()
{
    int a[] = {4,2,-3,-1,0,4};
    int n = sizeof(a)/sizeof(a[0]);
    
    ZeroSum(a,n);
}
*/

/*

#include<iostream>
#include<unordered_map>
using namespace std;
void ZeroSum(int *a,int n)
{
    unordered_multimap<int,int>map;
    for(int i=0;i<n;i++)
    {
        if(map.find(a[i])!=map.end())
        {
            if(i-map[a[i]]<=k)
                return 1;
        }
        map[a[i]] = i;
        
    }
    return 0;
}

int main()
{
    int a[] = {4,2,-3,-1,0,4};
    int n = sizeof(a)/sizeof(a[0]);
    
    ZeroSum(a,n);
}

*/

