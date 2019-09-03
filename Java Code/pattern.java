// WAP to print individual digit of a 3digit no(3)
import java.util.*;

class pattern
{
    public static void main(String args[])
    {
        int n;
        System.out.println("Enter any digit: ");
        Scanner sc = new Scanner(System.in);
        n = sc.nextInt(); 
        int a = n / 100;
        int b = (n%100) / 10;
        int c = n % 10;
        System.out.println(a);
        System.out.println(b);
        System.out.println(c);
    }
}