﻿// See https://aka.ms/new-console-template for more informatio
using HelloooWorld;
using System;
namespace hellooWorld
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hiii, sakshi here");
            // object creation of a class
            calculate calculate = new calculate();
            calculate.AditionOfTwoNumbers();
            Console.ReadLine();
            calculate.SubtractionOfTwoNumbers();
           Console.ReadLine();
            calculate.MultiplicationOfTwoNumbers();
           Console.ReadLine();
            calculate.DivisionOfTwoNumbers();
            Console.ReadLine();

        }
    }
}