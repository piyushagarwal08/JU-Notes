import java.util.*;
// this is used to take input-output
class random1
{
    public static void main(String args[])
    {
        fun(); 
        // only static functions can be called
       
    }
    public static void fun()
    {
        int a=(int)((Math.random())*100);
        System.out.print("a="+a); // + makes the integer into strng by default
    }
}