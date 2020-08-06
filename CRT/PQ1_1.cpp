//1.WAP to input any two numbers and swap the variable's value without using temp variable.
#include<iostream>
using namespace std;
int main()
{
    int x,y;
    std::cout<<"Enter Value of X:"<<endl;
    std::cin>>x;
    std::cout<<"Enter Value of Y:"<<endl;
    std::cin>>y;
    x^=y;y^=x;x^=y;
    std::cout<<"X is: "<<x<<endl;
    std::cout<<"Y is: "<<y<<endl;
    return 0;
}

//2 WAP to input any three numbers and swap the variable's value without using temp variable
#include<iostream>
using namespace std;
int main()
{
    int x,y,z;
    std::cout<<"Enter Value of X:"<<endl;
    std::cin>>x;
    std::cout<<"Enter Value of Y:"<<endl;
    std::cin>>y;
    std::cout<<"Enter Value of Z:"<<endl;
    std::cin>>z;
    x^=y;y^=x;x^=y;
    y^=z;z^=y;y^=z;
    std::cout<<"X is: "<<x<<endl;
    std::cout<<"Y is: "<<y<<endl;
    std::cout<<"Z is: "<<z<<endl;
    return 0;
}

// 3.WAP to input any five-digit number and find the sum of first and last digit.

#include<iostream>
using namespace std;

int main()
{
    int x,sum;
    std::cout<<"Enter any 5 digit number: ";
    std::cin>>x;
    sum = x/100000 +  x%10;
    std::cout<<"Value of sum is: "<<sum<<endl;
    return 0;
}


// 4.WAP to input any temperature and convert it into Fahrenheit and vice versa also.

#include<iostream>
using namespace std;

// 1 F = (1 K - 273.15)*9/5+32;
int main()
{
    float K,F;
    std::cout<<"Enter temperature in Kelvin: ";
    std::cin>>K;
    F = (K - 273.15)*9/5+32;
    std::cout<<"temperature is "<<F<<" Fahrenheit"<<endl;
    return 0;
}

// 5.WAP to input any five subject marks and find the total and percentage

#include<iostream>
using namespace std;

int main()
{
    int subjects[5],sum=0;
    std::cout<<"Enter Marks of 5 Subjects: "<<endl;
    for(int i=0;i<5;i++)
    {
        std::cin>>subjects[i];
        sum = sum+subjects[i];
    }
    std::cout<<"The total is: "<<sum<<endl;
    std::cout<<"The Percentage is: "<<(float)sum/5<<"%"<<endl;
    
    return 0;
}

// 6.WAP to input any principle, rate and time. Find the simple interest and compound interest

#include<iostream>
using namespace std;

int main()
{
    float principle,rate,time,si,ci;
    std::cout<<"Principle: ";
    std::cin>>principle;
    std::cout<<"Rate: ";
    std::cin>>rate;
    std::cout<<"Time: ";
    std::cin>>time;
    si=(principle*rate*time)/100;
    ci = si+principle;
    std::cout<<"Your simple interest is: "<<si<<" and the Amount: "<<ci<<endl;

    return  0;
}


/* 7.WAP to print the following series:

a) 1	-2	3	-4	5	-6	7	-8	9	-10
b) -1	2	-3	4	-5	6	-7	8	-9	10
c) 1	4	9	16	25	36	49	64	81	100
*/

#include<iostream>
using namespace std;


int main()
{
    for(int i=1;i<=10;i++) // a
    {
        if(i%2==0)
        {
            std::cout<<0-i<<"\t";
        }
        else
        std::cout<<i<<"\t";
    }

    std::cout<<endl; //newline

    for(int i=1;i<=10;i++) //b
    {
        if(i%2==0)
        std::cout<<i<<"\t";
        else
        std::cout<<0-i<<"\t";
    }

    std::cout<<endl;  //newline

    for(int i=1;i<=10;i++) //c
        std::cout<<i*i<<"\t";

    return 0;
}

