// WAP to read 2 integers and print larger number out of those (4)
// if the numbers are similar print that
import java.util.*;
class Size
{
    public static void main(String args[])
    {
        System.out.println("Enter value of a and b: ");
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        int b = sc.nextInt();

        if (a>b)
        {
            System.out.println("a is greater then b");
        }   
        else if (a < b)
        {
            System.out.println("b is greater then a");
        }
        else
        {
            System.out.print("both are equal");
        }

    }
}