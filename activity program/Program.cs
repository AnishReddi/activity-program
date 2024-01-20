using System;
namespace CSharpFundamentalsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your First Name:");
            string firstname = Console.ReadLine();

            Console.WriteLine("Please Enter Your Last Name:");
            string lastname = Console.ReadLine();

            Console.WriteLine("Please Enter Your Student ID:");
            string id = Console.ReadLine();

            string result = $"{firstname[0]}.{lastname}{id.Substring(5, 4)}@conestogac.on.ca";
            Console.WriteLine(result.ToLower());









        }


    }
}
