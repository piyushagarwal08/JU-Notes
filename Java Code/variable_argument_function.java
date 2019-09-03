import java.util.*;
// this is used to take input-output
class variable_argument_function
{
    public static void main(String args[])
    {
        fun(100,200,003); 
        // only static functions can be called
       
    }
    public static void fun(int...a) // int...a will works as an array
    {
        // int...a  it means no of values given to a will be decided at run time
        System.out.println("length="+a.length);
        for(int i:a)
            System.out.print(i+" ");
    }
}