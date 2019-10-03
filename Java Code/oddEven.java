import java.util.*;

class oddEven
{
	public static void main(String[] args)
	{
		Scanner obj=new Scanner(System.in);
		System.out.print("Enter any number: ");
		int x = obj.nextInt();
		int y = x/2;
		if(2*y==x)
			System.out.println("Even");
		else
			System.out.println("Odd");
	}
}