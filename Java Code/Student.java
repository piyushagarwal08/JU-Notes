// WAP in java to get total marks of five students using student class 
// 1 registration number
// 2 name 
// 3 marks in array 
// 4 total int

import java.util.Scanner;
class Student{
    public static void main(String[] args){
    Scanner s = new Scanner(System.in);
    for(int j=0;j<5;j++){
    System.out.println("Registration"+j);
    String reg = s.nextLine();
    System.out.println("Student"+j);
    String name = s.nextLine();
    int a[] = new int[5];
    for(int i = 0;i<5;i++){
        System.out.println("Enter the marks in Subject"+i+" :");
        int marks = s.nextInt();
        a[i] = marks;
    }
    int count = 0;
    for (int i:a)
        count += i;
    System.out.println(name+"with reg.no: "+reg+" got :"+count);
    }
    s.close();
}
}