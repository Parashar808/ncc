// See https://aka.ms/new-console-template for more information
using System;
namespace Typecasting
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("About TypeCasting");

            LoopingStatement();
            return;
        }


        

        public static void LoopingStatement()
        {
            string res = Console.ReadLine();

            
            do{
                Console.WriteLine("Do you want to continue?");
            }while(res.ToUpper() == "Y");
        }
    }
}
