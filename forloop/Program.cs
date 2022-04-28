using System;
namespace forloop{
    public class program{
        public static void Main(){
            stringmax();
            usingfor();
            return;
        }
    public static void stringmax(){
        string a="parashar";
        string b="baral";
        string res=a + "  " + b;
        Console.WriteLine(res);
        return;

    }
    public static void usingfor(){
        string[] days=new string[] { "sunday ","monday","tuesday","wednesday","thursday","friday","saturday"};
        for (int i = 0; i < days.Length ; i++){
            Console.WriteLine("days="+days[i]);

        }

    }
    }
}