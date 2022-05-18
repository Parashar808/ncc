using System;
namespace interfacepractise{
    public interface Ibus {
       void horn();
         void tyre();
    }

    public class smallbus: Ibus{
       public  void horn(){
            Console.WriteLine("I don't have loud horn.");
        }

        public void tyre(){
            Console.WriteLine("I have small tyres. ");
        }

    }
    public class Largebus: Ibus{
       public  void horn(){
            Console.WriteLine("I have loud horn.");
        }

        public void tyre(){
            Console.WriteLine("I have big tyres. ");
        }

    }
    class Program{
    public static void Main(){
        var b1= new Largebus();
        b1.horn();
        b1.tyre();

        var b2 = new smallbus();
        b2.horn();
        b2.tyre();

    }
}}