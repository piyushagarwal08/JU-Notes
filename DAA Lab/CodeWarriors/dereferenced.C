#include<stdio.h>

int main()
{
    int a = 50;
    char c='A';
    float f = 65.46;
    double d = 6.78;
    void *ptr;
    ptr = &c;
    // need to typecast else it won't know format to dereference the value
    printf("%d\n",*(int *)ptr); // 1644037953
    printf("%c\n",*(char *)ptr);  // A
    printf("%d",*(char *)ptr);  // 65
}