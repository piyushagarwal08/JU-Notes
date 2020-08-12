// Find the no of path possible to reach to origin from end at minimum cost
#include<iostream>
#include<string>
#include<unordered_map>
#define M 4
#define N 4
using namespace std;

unordered_map<string,int>map;

int CostPath(int mat[M][N],int m,int n,int cost)
{  
    if(cost==0)
        return 0;
    
    if(m==0 && n==0)
    {
        if(mat[0][0]-cost==0)
        return 1;
        else
        return 0;
    }

    // if above key is available in map then no need to traverse this path
    string key = to_string(m) + "|" + to_string(n) + "|" + to_string(cost);
    
    if(map.find(key)==map.end())
    {
        if(m==0)
            map[key] = CostPath(mat,0,n-1,cost-mat[m][n]);
        
        else if(n==0)
            map[key] = CostPath(mat,m-1,9,cost-mat[m][n]);

        else
            map[key] = CostPath(mat,m-1,n,cost-mat[m][n])+CostPath(mat,m,n-1,cost-mat[m][n]);

    }
    return map[key];

}
int main()
{
    int mat[M][N] = {{4,7,1,6},{5,7,3,9},{7,1,6,3}};
    printf("%d", CostPath(mat,M,N,25));
    return 0;
}

/* Find minimum cost to traverse a path in a matric
Assuming we can move only down or right
*/
#include<stdio.h>
#include<limits.h>
#define M 5
#define N 5

int min(int a,int b)
{
    return a>b?a:b;
}

int FindMinCost(int cost[M][N],int m,int n)
{
    int T[M][N];
    for(int i=0;i<M;i++)
    {
        for(int j=0;j<N;j++)
        {
            T[i][j] = cost[i][j];

            //we can move only right
            if(i==0 && j>0)
                T[0][j] = T[0][j] + T[0][j-1];

            // we can move only down
            else if(j==0 && i>0)
                T[i][0] = T[i][0] + T[i-1][0];

            // we can move down and right both     
            else if(i>0 && j>0)
                T[i][j] = T[i][j] + min(T[i-1][j],T[i][j-1]);
    }
    }
    return T[M-1][N-1];
}

int main()
{
    int cost[M][N] = {{4,7,8,6,4},{6,7,3,9,2},{3,8,1,2,4},{7,1,7,3,7},{2,9,8,9,3}};
    printf("%d",FindMinCost(cost,M,N));
    return 0;
}

/*
Given a matrix of MxN size and two coordinates P,Q, find the sum of the sub-matrix
*/

/* 
S={7,3,2,1,5,4,8}
divide this subset into 3 sub-sets such that there sum remains same while using all the elements
If Possible say Yes else No 
*/
