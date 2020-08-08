/* 1.WAP to input any string and find the length of the given string */
```cpp
#include<iostream>
#include<cstring> // to use the length function
using namespace std;

int main()
{
    string s;
    getline(cin,s);
    std::cout<<s.length(); // calculates the length of string
    return 0;
}
```

/* 2.WAP to print the following pyramid
0			
1	1		
2	3	5	
8	13	21	34
*/
```cpp
#include<iostream>
using namespace std;

int fibonacci(int n)
{
    if(n==1)
        return 0;
    if(n==2)
        return 1;
    return fibonacci(n-1)+fibonacci(n-2);
}

int main()
{
    int row = 4,x=1;
    for(int i=1;i<=row;i++)
    {
        
        for(int j=1;j<=i;j++)
        {
            cout<<fibonacci(x)<<" ";
            x++;
        }
        cout<<"\n";
    }
    return 0;
}
```

/* 3.WAP to input any two matrix and find the following

    1.Addition of Two Matrix

    2.Subtraction Operation

    3.Multiplication of Matrix
*/

/* 4.WAP to print the armstrong number from 1 to 50000 */
// Number which is equal to the cube of its digits
```cpp
#include<iostream>
#include<cmath>
using namespace std;

int Armstrong(int n)
{
    int temp=n,sum=0;
    while(n>0)
    {
        sum += pow(n%10,3);
        n /= 10;
    }
    if(sum==temp)
        return 1;
    else
        return 0;
}

int main()
{
    for(int i=1;i<=50000;i++)
    {
        if(Armstrong(i))
            std::cout<<i<<" ";
    }
    return 0;
}
```

/* 5.WAP to print the prime numbers from 2 to 100 */
#include<iostream>
using namespace std;

int Prime(int n)
{
    for(int i=2;i<n/2;i++)
    {
        if(n%i==0)
            return 0;
    }
    return 1;
}
int main()
{
    for(int i=2;i<=100;i++)
    {
        if(Prime(i))
            std::cout<<i<<" ";
    }
    return 0;
}
```










