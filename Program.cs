using System;
using dotnet_rpg.src.Entities;

namespace dotnet_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.Write(arus.Attack());
            Console.Write(wizard.Attack());
        }
    }
}