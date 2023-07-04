// See https://aka.ms/new-console-template for more information

using DesingPatternSection1;
using System;

class Program
{
    static void Main()
    {
        // Singleton object1 = new();//this is not allow due to the its protection lavel

        Singleton Object1 = Singleton.Instance();//instance is the public static method
        Singleton Object2 = Singleton.Instance();

        Console.WriteLine(Object1.Setting);//color blue
        Console.WriteLine(Object2.Setting);//color blue

        //let's ckeck without a doubt that this is a singleton
        //this is going to check in the momory to make sure that it's the same exact object
        //if it's the same place in memory it's going to console log this message
        if (Object1 == Object2)
        {
            Console.WriteLine("This objects are the same ");
        }
    }
}
