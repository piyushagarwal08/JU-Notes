#include<stdio.h>
void column(int n,int i,int j)
{
    if(j==0)
        return;
    printf("%d\t",n);
    column(n+i,i-1,j-1);
}

void row(int n,int i)
{
    if(n==0)
        return;
    row(n-1,i);
    column(n,i,n);
    printf("\n");
}
int main()
{
    int n;
    printf("Enter value of n:");
    scanf("%d",&n);
    row(n,n-1);
    return 0;
}