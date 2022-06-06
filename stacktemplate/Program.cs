using System;
namespace example
{
    class program1{

             public static void Main(){
                programstack<int> obj1= new programstack<int>();

                programstack<string> obj2= new programstack<string>();
                obj1.push(5);
                // obj1.print();
                obj1.push(7);
                // obj1.print();
                obj1.push(10);
                // obj1.print();
                
                obj1.pop();
                obj1.print();


                obj2.push("parashar");
                obj2.push("anjal");
                obj2.push("ranjit");
                obj2.pop();
                obj2.print();

            }

    }
    
}