import java.util.Scanner;

class UserDefinedException extends Exception{
    public String toString(){
        return "Hey you initialized an error";
    }
}

class UserException extends UserDefinedException{
    public static void main(String args[]) throws UserDefinedException{
        int a,b,c;
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter values of a and b: ");
        a=scan.nextInt();
        b=scan.nextInt();
        scan.close();
        c = a*b;
        try{
            if (c<100)
                throw new UserDefinedException();
            else
                System.out.println("a multiply b : "+c);
        }
        catch(UserDefinedException e){
            System.out.println("Exception is as: "+e);
        }
    }
}