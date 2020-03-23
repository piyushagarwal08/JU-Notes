#include<stdio.h>
#include<limits.h>

int main()
{
    int a[7] = {0,40,30,10,19,1,7};
    int s,r,q,p;
    int max = INT_MIN,max1=INT_MIN,min=INT_MAX,min1=INT_MAX;
    
    // for A[s]
    for(int i=3;i<6;i++)
    {
        if(*(a+i)>max)
        {
            max = *(a+i);
            s=i;
        }
    }

    for(int i=1;i<s-1;i++)
    {
        if(*(a+i)>max1)
        {
            max1 = *(a+i);
            q=i;
        }
    }    

    for(int i=q+1;i<s;i++)
    {
        if(*(a+i)<min)
        {
            min = *(a+i);
            r=i;
        }
    }

    for(int i=0;i<q;i++)
    {
        if(*(a+i)<min1)
        {
            min1 = *(a+i);
            p=i;
        }
    }
    printf("%d %d %d %d",s,r,q,p);
    printf("\n%d",a[s]-a[r]+a[q]-a[p]);
    return 0;
}