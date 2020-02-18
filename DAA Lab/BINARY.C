// Write a program to perform a binary search in the array of n size
// Write a program to perform a merge sort on 2 sorted arrays
// Write a program to perform a quick sort on a array of n size

#include<stdio.h>
//#include<conio.h>
int main()
{
    int first,i,last,middle,n,search,array[100];
    //clrscr();

    printf("Enter the number of elemenets: ");
    scanf("%d",&n);
    printf("Enter the %d numbers",n);
    for(i=0;i<n;i++){
	scanf("%d",&array[i]);
    }
    printf("Enter the value you want to find: ");
    scanf("%d",&search);

    first = 0;
    last = n-1;
    middle = (first+last)/2;

    while(first<=last){
	if(array[middle] < search)
	    first = middle + 1;
	else if (array[middle]==search){
	    printf("%d found at location %d \n",search,middle+1);
	    break;}
	else
	{
	    last = middle - 1;
	}
	middle = (first + last)/2;
    }
    if(first > last)
	printf("element %d not found in array",search);
    return 0;
    //getch();
}