#include<stdio.h>
int BinaryString(int n,int last)
{
    if(n==0)
        return 0;
    if(n==1)
    {
        if(last == 0)
        {
            return 2;
        }
        else
            return 1;
    }
    if(last == 0)
    {
        return BinaryString(n-1,0) + BinaryString(n-1,1);
    }
    else
        return BinaryString(n-1,0);
}
int main()
{
int n=3;
printf("%d",BinaryString(n,0));
return 0;
}