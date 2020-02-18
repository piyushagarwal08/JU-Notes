#include<stdio.h>

void PatternRow(int n)
{
    if(n<1)
        return;
    printf("%d\t",n);
    PatternRow(n-1);
}
void Pattern(int n)
{
    if(n<1)
        return;    
    PatternRow(n);
    printf("\n");
    Pattern(n-1);   
}

int main()
{
    int n;
    printf("Enter some value of n");
    scanf("%d",&n);
    Pattern(n);
    return 0;
}