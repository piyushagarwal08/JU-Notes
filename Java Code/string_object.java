// WAP in java to create a string object and initialise it with your name and perform the following operation
// 1. find the length of object
// 2. to find whether the character 'A' is present in the string , if yes then find the number of times it appear in your name else print 'a' i snot available

class String12{
    public static void main(String args[]){
        String s = new String("Piyush Agarwal");
     //   s = "Piyush Agarwal";
        System.out.println("The string is :"+s);
        int len = s.length();
        System.out.println("length of String is:"+len);
        int count = 0;
        for(int i =0;i< len;i++){
            if (s.charAt(i)==('A') || s.charAt(i)=='a'){
                count ++;
            }
        }
        if (count>0){
        System.out.print("A is present:"+count);
        }
        else{
            System.out.print("A  not present");
        }
    }
}