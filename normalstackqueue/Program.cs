using System;
namespace stack123
{
    class program{

        public static void Main(){

            int choice;
            int ch;
            var c1= new soperation();
            var d1 = new queue1();
            Console.WriteLine("enter 1 for stack and 2 for queue");
            int choice1=Convert.ToInt32(Console.ReadLine());

            switch(choice1){

                case 1: stack1234();
                break;

                case 2: queue123();
                break;

                default: break;

            }

           

            

         void stack1234(){
              do{
            Console.WriteLine("enter 1 to push and 2 to pop");
            choice=Convert.ToInt32(Console.ReadLine());
            
            switch(choice){
                case 1: c1.push();
                    break;
                case 2: c1.pop();
                    break;
                default: break;
               
            }
        
            Console.WriteLine("enter 1 to continue =");
            ch=Convert.ToInt32(Console.ReadLine());
            }while(ch==1);


            }

            void queue123(){

            
           
           do{
            Console.WriteLine("enter 1 to enqueue and 2 to dequeue");
            choice=Convert.ToInt32(Console.ReadLine());
            
            switch(choice){
                case 1: d1.enqueue();
                    break;
                case 2: d1.dequeue();
                    break;
                default: break;
               
            }
        
            Console.WriteLine("enter 1 to continue =");
            ch=Convert.ToInt32(Console.ReadLine());
            }while(ch==1);
            }
            
           
            
           

            
        }
    }
}
    
