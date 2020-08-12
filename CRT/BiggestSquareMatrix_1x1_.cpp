// Find the biggest  square matrix of 1 

/*
//This is of n^n size
#include<iostream>
#include<algorithm>
#define M 8
#define N 6
using namespace std;

<algorithm directive contains these functions>

int min(int a,int b)
{
    return a<b?a:b;
}
int max(int a,int b)
{
    return a>b?a:b;
}


int FindLargestSquareofOne(int mat[M][N],int m,int n,int &maxsize)
{
    if(m==0 || n==0)
    {
        if(maxsize!=0) // if any previous operation resulted in size of matrix
        {
            maxsize = max(maxsize,mat[m][n]);
            return mat[m][n];
        }
        for(int i=0;i<=m;i++) // check if atleast a single 1 is preset in any row
        {
            if(mat[i][n]==1)
            {
                maxsize = 1;
                break;
            }
        }
        for(int i=0;i<=n;i++) // check if atleast a single 1 is preset in any column
        {
            if(mat[m][i] == 1)
            {
                maxsize = 1;
                break;
            }
        }
        return maxsize;
    }
    
    int left = FindLargestSquareofOne(mat,m,n-1,maxsize);
    int top = FindLargestSquareofOne(mat,m-1,n,maxsize);
    int topleft = FindLargestSquareofOne(mat,m-1,n-1,maxsize);

    int size=0;
    if(mat[m][n]!=0)
    {
        size = 1+min(min(top,left),topleft);
    }
    maxsize = max(size,maxsize)
    return size;
}

int main()
{
    int mat[M][N] = {{0,0,1,0,1,1},
                        {0,1,1,1,0,0},
                        {0,0,1,1,1,1},
                        {1,1,0,1,1,1},
                        {1,1,1,1,1,1},
                        {1,1,0,1,1,1},
                        {1,0,1,1,1,1},
                        {1,1,1,0,1,1}
                     };
    int maxsize = 0;
    FindLargestSquareofOne(mat,M-1,N-1,maxsize);
    cout<<maxsize;
}
*/
#include<iostream>
#include<algorithm>
#define M 8
#define M 6
using namespace std;
int FLSO(int mat[M][N])
{
    int T[M][N];
    int max=0;
    for(int i=0;i<M;i++)
    {
        for(int j=0;j<N;j++)
        {
            T[i][j] = mat[i][j];

            if(i&&j&&mat[i][j])
            {
                T[i][j] = min(min(T[i-1][j],T[i][j-1],T[i-1][j-1]))+1;
            }

            if(max<T[i][j])
                max = T[i][j];
        }
    }
    return max;
}

int main()
{
    int mat[M][N] = {{0,0,1,0,1,1},
                        {0,1,1,1,0,0},
                        {0,0,1,1,1,1},
                        {1,1,0,1,1,1},
                        {1,1,1,1,1,1},
                        {1,1,0,1,1,1},
                        {1,0,1,1,1,1},
                        {1,1,1,0,1,1}
                     };
    int maxsize = 0;
    FindLargestSquareofOne(mat,M-1,N-1,maxsize);
    cout<<maxsize;
}