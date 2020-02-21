#include<stdio.h>

int LCM(int i,int j,int x)
{
    static int k=2;

    if(i%k==0 && j%k==0)
    {
        x=x*k;
        LCM(i/k,j/k,x);
    }
    else
    {
        if(k>i/2 && k>j/2)
        {
            x = x*i*j;
            return x;
        }
        else
        {
            k++;
            LCM(i,j,x);
        }   
    }
}

int main()
{
    int n,m,F;
    printf("Enter value of any 2 numbers: ");
    scanf("%d %d",&n,&m);
    F=LCM(m,n,1);
    printf("LCM of %d and %d is: %d",m,n,F);
    return 0;
}