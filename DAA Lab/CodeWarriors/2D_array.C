#include<stdio.h>

void Display(int (*p)[4],int r,int c){
    int i,j;
    printf("%d\n",sizeof(p));  // why size is coming 8 is it because of 64bit system
    for(i=0;i<r;i++){
        for(j=0;j<c;j++){
            printf("%d\t",*(*(p+i)+j));
        }
        printf("\n");
    }
}

int main(){
    int a[3][4] = {1,2,3,4,5,6,7,8,9,10,11,12};
    int r,c;
    printf("address in a: %d\n",a);
    r = sizeof(a)/sizeof(a[0]); // calculate no of rows a=16*3 / a[0]  = 16
    c = sizeof(a[0])/sizeof(int); // calculate no of columns 16/4  = 4
    Display(a,r,c); // call the function a->6421984,r->3,c->4
    return 0;
}