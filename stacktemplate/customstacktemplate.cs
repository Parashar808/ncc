namespace example{
    public class programstack<T>{
        private T[] s1= new T[5];
        private int counter =-1;

        public void push(T item)
        {
            if(counter<4){
                counter++ ;
                s1[counter]=item;

            }

            else{
                Console.WriteLine("overflow");
            }

        }

        public void pop(){

            if(counter>=0){
                s1[counter]=default(T);
                counter--;

            }  
            else{
                Console.WriteLine("underflow ");

            }          
        }

        public void print(){
            Console.WriteLine("the elements of stack are = ");
            for(int c=0;c<=counter;c++)
                Console.WriteLine(s1[c]); 
                Console.WriteLine("");

        }
    


    }

}
