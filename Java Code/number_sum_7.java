// 7. WAP in JAVA to find sum of digits of a number
import java.util.*;
class number_sum_7{
    public static void main(String args[])
    {
        System.out.println("Enter a number: ");
        Scanner s = new Scanner(System.in);
        
        int a = s.nextInt();
        int sum = 0;
        while (a > 9)
        {
            sum += a % 10;
            a = a/10;
        }
        sum +=a;
        System.out.print("The sum of entered number is: "+sum);
        s.close();
    }
}