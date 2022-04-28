using System;
using System.Text;
namespace forloop{
    public class program{
        public static void Main(){
            stringmax();
            usingfor();
            stringformat();
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
    public static void stringformat(){
        string x="Anjal";
        string y="Thapa";
        Console.WriteLine(string.Format("{0} {1}",x,y));

        //string interpolation
        string a="hello";
        string b="nicky";

        string res=$"{a}! {b}" ;
        Console.WriteLine(res);

        //string builder (using System.Text;)

        StringBuilder abc= new StringBuilder();
        abc.AppendLine("This is a ");
        abc.AppendLine("appended line.");
        string res1=abc.ToString();
        Console.WriteLine(res1);



        
        return;

    }
    }
}