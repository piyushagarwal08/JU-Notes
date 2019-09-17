// WAP in JAVA to find largest and smallest number in array
import java.util.*;
class min_max
{
    public static void main(String args[])
    {
        int a[] = new int[5];
        Scanner sc = new Scanner(System.in);
        for (int i=0;i<5;i++)
        {
            a[i] = sc.nextInt();
        }
        int min = a[0];
        int max = a[0];
        for(int i =1;i<5;i++)
        {
            if(min>a[i])
            {
                min = a[i];
            }
            if(max<a[i])
            {
                max = a[i];
            }
        }
        System.out.println("Max is: "+max);
        System.out.println("Min is: "+min);

    }
}