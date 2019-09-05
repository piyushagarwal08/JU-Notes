// created a base class
class Super  // Java has a inbuild keyword super 
{
    int a = 0;

    // Creating a Constructor
    public Super() // name of constructor is same as class name
    {
        a = 1;
    }

    public void show()
    {
        System.out.println("A="+a);
    }
    public void getA(int x)
    {
        a = x;
    }
    public int getValueA()
    {
        return a; // it returns the value of variable a
        
    }
}

// created a derived class
class Sub extends Super 
{
    int b = 9;
    public Sub(int b)
    {
        super(); // it calls the constructor of the Base Class
        this.b=b;
    }
    public void display()
    {
        show();
        System.out.println("B="+b);
    }
    public void getB(int y)
    {
        getA(y*2);
        b = y;
    }
}

// this is the main class
class Day3Demo
{
    public static void main(String args[])
    {
        Sub obj=new Sub(4);
        obj.display();
        obj.getB(5);
        obj.display();
    }
}