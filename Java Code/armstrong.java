
// 9. WAP in JAVA to print all armstrong number from 1 to 1000
class armstrong{
    public static void main(String args[])
    { 
        int n,b,i,sum=0;
        System.out.println("Armstrong no from 0 to 1000");
        for (i=1;i<=1000;i++)
        {
            n=i;
            while(n>0)
            {
                b = n%10;
                sum += b*b*b;
                n = n/10;
            }
            if (sum == i)
            {
                System.out.println(i+" ");
            }
            sum = 0;
        }

    }
}