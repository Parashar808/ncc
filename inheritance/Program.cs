using System;
namespace inheritance{
    public class program{

        public static void Main(){
            var a2= new class2(4); //this prints from both classes
            

        }


    }

    public class class1{
        public class1(){
            
        }

        
           

            public class1(int i){

                            Console.WriteLine($"the number of class1 is {i}");


            }
            

       
        

    }
    public class class2: class1{

        public class2(){

        }

        public class2(int i):base(i){

            Console.WriteLine($"the number of class2 is {i}");

        }
    }
}