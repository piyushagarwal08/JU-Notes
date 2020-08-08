/*1. WAP to print the sum of the following series:
        sum = 1 + 1/2! + 1/3! + 1/4! + ......... + 1/n!
*/
```cpp
#include<iostream>
using namespace std;

int factorial(int n)
{
    int value=1;
    while(n>0)
    {   
        value = value * n;
        n--;
    }
    return value;
}

int main()
{
    int x;
    float sum=0;
    std::cin>>x;
    
    for(int i=1;i<=x;i++)
    {
        sum = sum +  (1/(float)factorial(i));
    }
    std::cout<<sum;
    return 0;
}
```

/* 2. WAP to print the following pyramid using function:

A	     A
AB	    BA
ABC	   CBA
ABCD  DCBA
ABCDEEDCBA
ABCD  DCBA
ABC	   CBA
AB	    BA
A	     A

*/


/* 3.WAP to input any any ten values in an array, find the sum of positive numbers, sum of negative numbers,
 count positive numbers, count negative numbers also.*/
```cpp
#include<iostream>
using namespace std;

int main()
{
    int numbers=10;
    int a[numbers],p_sum,n_sum,p_count,n_count;
    for(int i=0;i<numbers;i++)
    {
        std::cin>>a[i];
        a[i]>=0?p_sum+=a[i]:n_sum+=a[i];
        a[i]>=0?p_count++:n_count++;
    }
    for(int i=0;i<numbers;i++)
        std::cout<<a[i]<<" ";
    std::cout<<"Positive Number Sum: "<<p_sum<<"\n"<<"Negative Sum: "<<n_sum<<endl;
    std::cout<<"Positive Number Count: "<<p_count<<"\n"<<"Negative Number Count: "<<n_count<<endl;
    return 0;
}
```

/* 4.WAP to find the lucky number of the given number
I/P: 1234567
O/P:1+2+3+4+5+6+7=28=>2+8=10=>1+0=1

I/P: 5598
O/P:5+5+9+8=27=2+7=9
*/
```cpp
#include<iostream>
using namespace std;

int digit_sum(int y)
{
    int sum=0,m;
    while(y>0)
    {
        m = y % 10;
        sum = sum + m;
        y = y/10;
    
    }
    return sum;
}

int main()
{
    int n,sum;
    cin>>n;
    while(n>0)
    {
        sum = digit_sum(n);
        n=sum;
        if(n<10)
            break;
    }
    cout<<n;
    return 0;
}
```

/*5.WAP to print the following pyramid using function
1

2	3

5	7	11

13	17	19	23
*/


