using Eclipse;
using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pwd = new PasswordHashing();

            pwd.GenerateSalt();
            var salt = pwd.salt;

            var hash  = pwd.HashPassword("password");
            Console.WriteLine(hash);
            Console.WriteLine();
            hash = pwd.HashPassword("Password");
            Console.WriteLine(hash);
            Console.WriteLine();
            hash = pwd.HashPassword("Password");
            Console.WriteLine(hash);
        }
    }
}