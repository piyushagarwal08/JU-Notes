#include <stdarg.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define MIN_ELEMENT 1
#define MAX_ELEMENT 1000000
int  sum (int count,...) {
    va_list list;
    va_start(list,count);   
    int sum=0;
    for(int i=1;i<=count;i++)
        sum += va_arg(list,int);
    va_end(list);
    return sum;
}

int min(int count,...) {
    int min = MAX_ELEMENT,value;
    va_list list;
    va_start(list,count);
    
    for(int i=1;i<=count;i++)
    {
        value = va_arg(list,int); // works
        /*
        if(min>va_args(list,int))
        {
            min = va_args(list,int)
        }
        */
        if(value<min)
            min = value;
    }
    va_end(list);
    return min;
}

int max(int count,...) {
    int max = MIN_ELEMENT,value;
    va_list list;
    va_start(list,count);
    
    for(int i=1;i<=count;i++)
    {   
        value = va_arg(list,int);
        if(value>max)
            max= value;
    }
    va_end(list);
    return max;
}

int test_implementations_by_sending_three_elements() {