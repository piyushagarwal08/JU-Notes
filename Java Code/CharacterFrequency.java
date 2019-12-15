//import java.io.*;
import java.util.Scanner;
class Count{
    static void CountChar(String str){
        int vowels=0,consonant=0,space=0,digit=0;
        for(int i =0;i<str.length();i++){
            char ch = str.charAt(i);

            if((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')){
                ch = Character.toLowerCase(ch);

                if(ch=='a' || ch=='e' || ch == 'i' || ch=='o' || ch=='u'){
                    vowels++;
                }
                else
                consonant++;
            }
            else if(ch >= '0' && ch <= '9')
            {
                digit++;
            }
            else
            space++;
        }
        System.out.println("Vowels: "+vowels);
        System.out.println("Consonant: "+consonant);
        System.out.println("Digits: "+digit);
        System.out.println("Space: "+space);
    }

    public static void main(String args[]){
        System.out.println("Enter a String: ");
        Scanner scan = new Scanner(System.in);
        String str = scan.nextLine();
        scan.close();
        CountChar(str);
    }
}