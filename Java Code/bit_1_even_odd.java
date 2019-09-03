// WAP to find if a number is even or odd without using mathematical operators

import java.util.*;
class bit_even_odd
{
    public static void main(String args[])
    {
        System.out.println("Enter any number: ");
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        if ( (n & 1) == 0)
        {
            System.out.print("Even");
        }
        else
        {
            System.out.print("Odd");
        }
    }
}