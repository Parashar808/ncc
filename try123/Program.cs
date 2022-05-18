using System;
namespace try1{
    public class try12{

        public static void Main(){

            nonstatic sc =new nonstatic();
       // static1 sc1= new static1(); this is not possible because static class ko object banauna mildaina
        nonstatic.functionone();
        var n1= new nonstatic();
        var n2= new nonstatic();
        var n3= new nonstatic();
        n1.functiontwo();
        n2.functiontwo();
        n3.functiontwo();

        }
        

    }
        public class nonstatic{
            public int e=10;
            public static int i=10;
            
            public static void functionone(){
               //e++; : invalid because static le non static nai bolauna mildaina

             }

             public void functiontwo(){
                 i++;
                 e++; //valid non le static lai milxa access garna
                 Console.WriteLine($"i={i}& e={e}"); //value of i will increase by1 in each function because tyo saved bhayera basxa but value of e 11 nai aauxa because each object ko function call ma naya bata call hunxa non static
             }
        }
        public static class static1{
            public static int i=10;
            public static void functionone(){

            }
        }
}