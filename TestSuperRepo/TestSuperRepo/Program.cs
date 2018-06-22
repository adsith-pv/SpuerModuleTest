using System;

namespace TestSuperRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cont = new Contract();
            Console.WriteLine(cont.ContractNumber());
            Console.ReadLine();
        }
    }
}
