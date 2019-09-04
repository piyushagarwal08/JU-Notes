class String_testing
{
    public static void main (String a[])
    {
        String s1="java";
        String s2=new String("Java");
        String s3=s1;

        // Simply printing String variables
        System.out.println("S1="+s1); 
        System.out.println("S2="+s2);
        System.out.println("S3="+s3);

      //  s2 = "Java";
        if (s1 == s3)
        {
            System.out.println("Same string s1 and s3");
        }

        if (s1 == s2)
        {
            System.out.println("same");
        }
        else
            System.out.println("Different");

        if (s1.equals(s2))  // used to check if two strings are equal or not
        {
            System.out.println("same");
        }
        else
            System.out.println("Different");


        if (s1.equalsIgnoreCase(s2))  // check string without case sensitive
        {
            System.out.println("same");
        }
        else
            System.out.print("Different");
        s1=s1.toLowerCase();
        s2 = s2.toUpperCase();
        System.out.println(s1+" " +s2);


        // Check the index of a character
        char c = s1.charAt(2);
        System.out.println(c);
    }
}