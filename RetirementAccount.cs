using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Virtual__Overriding__and_New
{
    internal class RetirementAccount : SavingsAccount
    {
       
        bool _withdraw;
        string _printout;


        public RetirementAccount(string name, double balance, double interest = 0.3) : base(name, balance, interest)
        {
          
        }

        public new void Withdraw(double amount)
        {
           _withdraw = false;
           _printout = "Cannot Withdraw from Retirement Account";
        }
        
        public override string ToString()
        {
            return base.ToString() + $"\n{_printout}";
        }
    }//class
}//namesapce
