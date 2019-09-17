
import java.util.*;
class assignment
{
    public static void main(String args[])
    {
        int a,k=0;
        Scanner sc = new Scanner(System.in);
        a = sc.nextInt();
        int b = a/2;
        for(int i=2;i<=b;i++)
        {
            if (a%i == 0)
            {
                k=1;
                break;
            }
        }
        if (k==0){
            System.out.print("Prime");
        }
        else{
            System.out.print("Not Prime");
        }
        sc.close();
    }
}