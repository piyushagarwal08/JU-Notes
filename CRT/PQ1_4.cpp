/* 1. WAP to print the following pyramid:
	    *
	   ***
      *****
     *******
    *********
     *******
      *****
       ***
        *
*/
#include<iostream>
using namespace std;

int main()
{
    for(int i=1;i<=5;i++)
    {
        for(int j=5-i;j>0;j--)
            std::cout<<" ";
        for(int j=1;j<=2*i-1;j++)
            std::cout<<"*";
        std::cout<<endl;
    }

    for(int i=4;i>0;i--)
    {
        for(int j=1;j<=5-i;j++)
            std::cout<<" ";
        for(int j=1;j<=2*i-1;j++)
            std::cout<<"*";
        std::cout<<endl;
    }
    return 0;
}

/* 2. WAP to print the following pyramid:
	   *****
      *      *
      *      *
      *      *
       *****
*/
#include<iostream>
using namespace std;

int main()
{
    for(int i=1;i<=5;i++)
    {
        if(i==1 || i==5)
        {
            std::cout<<" ";
            for(int j=1;j<=5;j++)
                std::cout<<"*";
        }
        else
        {
            for(int j=1;j<=7;j++)
            {
                if(j!=1 && j!=7)
                    std::cout<<" ";
                else
                    std::cout<<"*";
            }
        }
        std::cout<<endl;
    }
    return 0;
}

/* 3. WAP to print the following pyramid:
				1
	          1	  1
			1	2   1
          1	  3  3   1
		1   4  6   4  1
	  1	  5  10	 10 5   1
*/
#include<iostream>
using namespace std;
int main()
{
    int row = 6,coef = 1;
    for(int i = 0;i<row;i++)
    {
        for(int space=1;space<row-i;++space)
        {
            std::cout<<" ";
        }
        for(int j=0;j<=i;j++)
        {
            if(j==0 || i==0)
                coef = 1;
            else
                coef = coef*(i-j+1)/j;
                
            std::cout<<coef<<" ";
        }
        std::cout<<endl;
    }
    return 0;
}

/* 4. WAP to input any string with white spaces and print the string after removing the white space. */
#include<iostream>
#include<string>
using namespace std;
int main()
{
    string str;
    getline(cin,str);
    int n=str.length();
    for(int i=0;i<n;i++)
    {
        if(str[i]==' ')
            continue;
        std::cout<<str[i];
    }
    return 0;
}

/* 5. WAP to input any string and find the total number of vowels, consonants from the given string. */
#include<iostream>
#include<string>
using namespace std;
int main()
{
    int v=0,c=0,n;
    string str;
    getline(cin,str);
    n = str.length();
    for(int i=0;i<n;i++)
    {
        if(str[i]=='a' || str[i]=='e' || str[i]=='i' || str[i] == 'o' || str[i]=='u')
            v++;
        else
            c++;
    }
    std::cout<<"Vowels are: "<<v<<"\nConsonants are: "<<c;

    return 0;
}
