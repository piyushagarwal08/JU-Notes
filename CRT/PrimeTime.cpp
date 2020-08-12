// Prime Time
#include <iostream>
#include <string>
#include<cmath>
using namespace std;

int is_Prime(int n)
{
    if(n==1)
        return 0;
    for(int i=2;i<(int)pow(n,0.5)+1;i++)
  {
      if(n%i==0)
        return 0;
  }
  return 1;
}

int main()
{
    int D,P,HP,N,j,k,i;
    std::cin>>D>>P;
    HP = D/P;
    N=HP;
    int *arr = (int *)calloc(HP,sizeof(int));
    while(N>1)
    {
        i=1;
        while(true)
        {       
            j = (i-1)*HP+N;
         
            k = j - HP*(i-1)-1;
            if(i>1 && *(arr+k)==1)
            {

                if(is_Prime(j))
                    *(arr+k) = 1;
                else
                    *(arr+k) = 0;
            }
            else if(i==1)
            {
                if(is_Prime(j))
                    *(arr+k) = 1;
                else
                    *(arr+k) = 0;
            }
            
            
            if(i==P)
                break;
            i++;
        }
        N--;
    }
    N=HP;
    for(int m=0;m<HP;m++)
    {
        i=1;
        k=0;
        while(true)
        {
            
            if(*(arr+m)==1)
                std::cout<<m+k+1<<" ";
            
            if(i==P)
                break;
            i++;
            k+=HP;
        }
        N--;
    }
    
    
    return 0;
}
