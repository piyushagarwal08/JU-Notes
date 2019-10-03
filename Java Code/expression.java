import java.util.*;

class expression
{
	public static void main(String[] args)
	{
		int a=10, b=5, r1, r2, r3;
		System.out.println("Before:\na="+a+"\nb="+b);
		r1=a<<2;
		r2=(a+b*100)/10;
		r3=a&b;
		System.out.println("After:\nResult1="+r1+"\nResult2="+r2+"\nResult3="+r3);
	}
}