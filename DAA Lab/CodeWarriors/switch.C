#include<stdio.h>

void switch_case(int x,int y){
    switch(3){
        case 1: printf("case 1");
                break;
        case 2: printf("case 2");
                break;
        case 3: printf("case 3");
        
        case 4: printf("case 4");

        case 18: printf("case 18");
                 break;
        default: printf("kuch nahi aata");
    }
    return;
}

int main()
{
    int x=19,y=1;
    switch_case(x,y);
    return 0;
}