class Practice{
    static void fun(){
        try
        {
            throw new NullPointerException("hey");
        }
        catch(NullPointerException e)
        {
            System.out.println("The Above Try block sended me here\n"+e);
            throw e; // no idea
        }
    }
    public static void main(String args[]){
        try{
            fun();
        }
        catch(NullPointerException e){
            System.out.print("Main Block Catch");
        }
    }
}