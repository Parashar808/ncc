using System;
namespace stack123{
    class soperation{
         
         int i=-1;
         int element;
         int[] arr = new int[5];

        public void push(){

            if(i<4){
             Console.WriteLine("enter the element to push=");
             element=Convert.ToInt32(Console.ReadLine());

            i++;
            arr[i]=element;
            Console.WriteLine("the elements of array : ");
            for(int a=0;a<=i;a++){
            Console.WriteLine(arr[a]);
            }
            }

            else{
            Console.WriteLine("stack overflow");
            Console.WriteLine("the elements of array : ");
            for(int a=0;a<=i;a++){
             Console.WriteLine(arr[a]);
            }
            }
            
        

         }

         public void pop(){
             if(i>-1){

             
             arr[i]=default(int);
             i--;
            Console.WriteLine("You just poped an element");
            Console.WriteLine("the elements of array : ");

            for(int b=0;b<=i;b++){
            Console.WriteLine(arr[b]);
            }
            }

            else{
                 Console.WriteLine("stack underflow");
            }


            

         }


    }


        class queue1{

            int front=-1;
            int rear=-1;
            int[] q1= new int[6];

            public void enqueue(){
            Console.WriteLine("enter the element to enqueue=");
            int element1=Convert.ToInt32(Console.ReadLine());
            if(front==-1 && rear==-1){
                front++;
                rear++;
                q1[front]= element1;
                Console.WriteLine("the elements of queue are:");
            for(int c=front;c<=rear;c++){
                Console.WriteLine(q1[c]);
            }


            }

            else if(front !=rear){
                
                if(rear <6 ){
                rear++;
                q1[rear]=element1;
                Console.WriteLine("the elements of queue are:");
            for(int c=front;c<=rear;c++){
                Console.WriteLine(q1[c]);
            }}

                else{
                    Console.WriteLine("queue overflow");
                }

            }
            
            }

            public void dequeue(){

                if(front>-1){

                    front++;


                }

                else{
                    Console.WriteLine("queue underflow");
                }
                Console.WriteLine("the elements of queue are:");
            for(int c=front;c<=rear;c++){
                Console.WriteLine(q1[c]);
            }

            
             

            
            



            }

            
        


            



        }
    }