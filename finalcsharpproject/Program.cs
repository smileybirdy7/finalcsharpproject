﻿using System; 

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyFunction();
            myInt = IntFunction(22);
            string myString = StringFunction(Console.ReadLine());
            Console.WriteLine(myString);
        }
    }
    public int myInt = 10;
    
    public void MyFunction () {
        Console.WriteLine("Run Function");
    }
}
    public int IntFunction (int _peram) {
        return _peram + myInt;

    public static string StringFunction (string_name) {
        return "You did well" + _name;
    }
    
    }