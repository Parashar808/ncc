// See https://aka.ms/new-console-template for more information
using System;
namespace ClassObjects{
    

 public class Person
{
  private string name; // field
  public string Name   // property
  {
    get { return name; }
    set { 
        if (string.IsNullOrWhiteSpace(value))
                {
                    value = "Babu";
                }
        name = value; }
  }
}

class Program
{
  static void Main()
  {
    Person myObj = new Person();
    myObj.Name = "";
    Console.WriteLine(myObj.Name);
    return;
  }
}
      
      
}