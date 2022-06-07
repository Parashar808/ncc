using System;
namespace program{
    public class program1{

        public static void Main(){
        program2<int> new1= new program2<int>();
        new1.enqueue(5);
        new1.enqueue(7);
        new1.print();
        new1.dequeue();
        new1.dequeue();
        new1.print();


        program2<string> new2=new program2<string>();
        new2.enqueue("paarashar");
        new2.print();
        new2.enqueue("baral");
        new2.print();
        new2.dequeue();
        new2.print();



        
        
    }}
}