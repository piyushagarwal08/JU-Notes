import java.util.*;

class rectangle
{
	public static void main(String[] args)
	{
		Scanner obj=new Scanner(System.in);
		System.out.print("Enter length and breadth: ");
		Double l = obj.nextDouble();
		Double b = obj.nextDouble();
		Double area = l*b;
		System.out.println("Area = "+area);
	}
}