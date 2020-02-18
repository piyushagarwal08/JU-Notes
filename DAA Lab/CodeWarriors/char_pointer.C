#include<stdio.h>

int main()
{
    int a=357;  // variable a initialized
    int *p; // int * pointer  declared
    char *q;  // char * pointer declared
    p=&a;  //store address of a
    q = (char *)&a; // store address of a and convert it to char asterik form
    printf("%d\t%d\n",*p,*q); // 357 and 101
    printf("address of a: %d %d\n",p,q); // 6422028 and 6422028
    ++p; // p+4 
    ++q; // q+1 
    printf("%d\t%d\n",p,q); // 6422032 and 6422028
    printf("%d\t%d\n",*p,*q); //
}