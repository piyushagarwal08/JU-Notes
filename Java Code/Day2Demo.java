class abc
{
    String s="Pykid";
    public void show()
    {
        System.out.println("Hello"+s);
    }
}

class Day2Demo extends abc
{
    public static void main(String [] at)
    {
    abc a = new abc(); // made a object of the self made class
    a.show();

    }
}