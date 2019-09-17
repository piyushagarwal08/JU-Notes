// 8. WAP in JAVA to find first 15 numbers of fibonacci series
class fibonacci
{
    public static void main(String args[])
    {
        int a = 0,b=1,c,i;
        System.out.print(a+" "+b);
        for(i=2;i<15;i++)
        {
            c = a+b;
            System.out.print(" "+c);
            a=b;
            b=c;
        }
    }
}    
