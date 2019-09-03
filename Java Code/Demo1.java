import java.util.*;
// this is used to take input-output
class Demo1
{
    public static void main(String args[])
    {
        int a;
        Scanner sc=new Scanner(System.in); // object of the same class
        System.out.print("enter the value of a: ");
        a = sc.nextInt();  // Camel Notation used in java
        // nextInt works same as scanf of C 

        // static defines that we can call this function without using object of this class
        System.out.print("a=" + a);
    }
}