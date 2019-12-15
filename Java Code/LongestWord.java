import java.util.Scanner;
import java.io.*;

public class LongestWord{
    public static void main(String args[]){
        new LongestWord().findLongestWord();
    }

    public void findLongestWord(){
        
        String longest_word = "";
        String current ;
        Scanner scan = new Scanner(new File("C:/Users/piyus/Desktop/File.txt"));

        while(scan.hasNext()){
            current = scan.next();
            if(current.length()> longest_word.length())
            longest_word = current;
        }
        scan.close();
        System.out.println(longest_word);
    }
}