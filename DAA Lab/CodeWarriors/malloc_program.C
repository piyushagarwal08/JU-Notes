#include<stdio.h>
#include<stdlib.h>

int main()
{
    int **m;
    int r,c,i,j;
    printf("Enter no of rows and columns: ");
    scanf("%d %d",&r,&c);
    m = (int **)malloc(r*sizeof(int *)); // malloc would have given void * by default
    printf("this line %d\n",m);

    for(i=0;i<r;i++){
        for(j=0;j<c;j++)
            scanf("%d",*(m+i)+j);
    }
    printf("Its over");
    printf("%d",*(*(m)+1));
    for(i=0;i<r;i++){
        for(j=0;j<c;j++)
            printf("%d",m[i][j]);
        printf("\n");
    }

    for(i=0;i<r;i++)
        free(m[i]);
    free(m);
}