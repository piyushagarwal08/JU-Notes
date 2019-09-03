// WAP to find the maximum number among three (6)

import java.util.*;
class max
{
    public static void main(String args[])
    {
        System.out.println("Enter any 3 numbers: ");
        Scanner sc = new Scanner(System.in);

        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();

        if (a>b && a>c)
        {
            System.out.print(a+" is maximum");
        }
        else if (b>a && b>c)
        {
            System.out.print(b+" is maximum");
        }
        else
        {
            System.out.print(c+" is maximum");
        }
        
    }
}
