// WAP to tell if a taken input is even or odd without using modulus operator (5)
import java.util.*;

class Even_ODD
{
    public static void main(String args[])
    {

    System.out.println("Enter any input value: ");
    Scanner sc = new Scanner(System.in);
    int a = sc.nextInt();
    int q = a/2;
    if (2*q == a)
    {
        System.out.println("Even");
    }
    else
    {
        System.out.print("Odd");
    }
}
}