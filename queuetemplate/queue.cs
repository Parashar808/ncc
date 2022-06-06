namespace program{

        public class program2<T>{
            public T[] t1= new T[5];
            
            public int rear=-1;
            public int front=-1;

            public void enqueue(T item){
            if(front==-1 && rear==-1){
                front++;
                rear++;
                t1[front]= t1[rear]=item ;
            
            }
            else if(front !=rear){
                
                if(rear <5 ){
                rear++;
                t1[rear]=item;
                    }
                 }
             else{
                    Console.WriteLine("queue overflow");
                }
            }
            public void dequeue(){

                if(front>-1){
                    t1[front]=default(T);
                    front++;


                }

            
}
public void print(){
                for(int a=front;a<=rear;a++){
                    Console.WriteLine(t1[a]);

                }
            }
}

}
