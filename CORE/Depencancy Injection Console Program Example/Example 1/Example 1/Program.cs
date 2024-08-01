using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{

    interface IAccount
    {
       void printdetailes();
    }
    class CurrentAccount : IAccount
    {
       public void printdetailes()
        {
            Console.WriteLine("CurrentAccount Class is Calling");
        }
    }

    class Account
    {
        public  readonly  IAccount account;

        public Account(IAccount account)
        {
            this.account = account;
        }
        public void printaccount()
        {
          
            account.printdetailes();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount ac = new CurrentAccount();
   

            Account a = new Account(ac);
            a.printaccount();

            Console.ReadLine();

        }
    }
}
