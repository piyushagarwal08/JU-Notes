#include<stdio.h>
int BinaryString(int n)
{
    int T[n+1][2];
    T[0][0] = 0;
    T[0][1] = 0;
    T[1][0] = 2;
    T[1][1] = 1;
    for(int i=2;i<=n;i++)
    {
        T[i][0] = T[i-1][0] + T[i-1][1];
        T[i][1] = T[i-1][0];
    }
    return T[n][0];
}
int main()
{
    int N=5;
    printf("%d",BinaryString(N));
}