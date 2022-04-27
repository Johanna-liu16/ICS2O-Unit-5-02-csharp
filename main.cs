// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math
using System;

class Program
{
    public static void Main(string[] args)
    {

        // This function states user's address input. 
        int userInteger;

        //Input 
        Console.WriteLine("This program identifies integers.");
        Console.WriteLine("");
        Console.Write("Enter an integer: ");
        userInteger = Convert.ToInt32(Console.ReadLine());

        //Process
        if (userInteger >= 0){
            Console.WriteLine("Integer is a positive number.");
        }else{
            Console.WriteLine("Integer is a negative number.");
        }

        Console.WriteLine("\nDone.");
    }
}