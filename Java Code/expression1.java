// WAP to find result of following expression:   (2)
// 1. a<<2 (2). (a+b * 100)/2   (3). a & b
import java.util.*;
class operator
{
    public static void main(String args[])
    {
        int a,b;
        System.out.print("enter any value for a: ");
        Scanner sc=new Scanner(System.in);
        a = sc.nextInt();
        b = a<<2;
        System.out.println("value of a is: " + a); // after print it will create a new line
        System.out.println("Value of a<<2: "+b );

        System.out.println("enter value of a & b");
        a = sc.nextInt();
        b = sc.nextInt();
        int c = (a+b * 100 ) / 2;
        int d = (a + (b*100))/2;
        System.out.println("value of (a+b * 100)/2: "+c); //same as below
        System.out.println("value of (a+(b * 100))/2: "+d);

        a  = sc.nextInt();
        b = sc.nextInt();
        c = a & b;
        System.out.println("value of a & b: "+c);
        
    }
}