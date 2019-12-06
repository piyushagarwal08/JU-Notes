import java.util.*;
// this is used to take input-output
class random
{
    public static void main(String args[])
    {
        int a;
        
        a = (int)((Math.random())*100); 
        // static methods can be define without importing class as class-name.method
        // static defines that we can call this function without using object of this class
        System.out.print("a=" + a);
    }
}