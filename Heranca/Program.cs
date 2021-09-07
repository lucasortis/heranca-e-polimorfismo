using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBusiness acc1 = new AccountBusiness(200, 3401, "Lucas Ortis", 2000);

            Console.WriteLine(acc1.Balance);

            // acc1.Balance = 20;
        }
    }
}
