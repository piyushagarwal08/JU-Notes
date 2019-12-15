class EvenThread extends Thread{
    EvenThread(String name){
        super(name);
    }
    public void run(){
    try{

for(int i=1;i<50;i++)
{
if (i%2==0)
System.out.println(getName()+"\t"+i);
Thread.sleep(10);
}
System.out.println("Exit from thread "+getName());
}
catch(InterruptedException e)
{
System.out.println("Thread "+getName()+" Interrupted");
}

} }

/* Thread to generate odd number */

class OddThread extends Thread

{

OddThread(String name)

{

super(name);

}

public void run()

{

try

{

for(int i=1;i<50;i++)

{

if (i%2!=0)

System.out.println(getName()+"\t"+i);

Thread.sleep(30);

}

System.out.println("Exit from thread "+getName());

}

catch(InterruptedException e)

{

System.out.println("Thread "+getName()+" Interrupted");

}

}

}

/* Thread Demo */

class ThreadDemo

{

public static void main(String args[])

{

EvenThread e=new EvenThread("Even");

OddThread o=new OddThread("Odd");

e.start();

o.start();

}

} 