using System;
using dotnet.Models;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             
            BadUser badUser = new BadUser("dupa@op.pl", "123456");
        }
    }
}
