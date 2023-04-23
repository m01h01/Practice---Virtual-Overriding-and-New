using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Virtual__Overriding__and_New
{
    internal class CheckingAccount : BankAccount
    {
        double _overdraftFee;
        public CheckingAccount(string name, double balance, double overdraftFee = 50) : base(name, balance)
        {
            _overdraftFee = overdraftFee;
        }

        public double OverdraftFee { get => _overdraftFee; set => _overdraftFee = value; }
      
        public override bool Withdraw(double amount)
        {
            bool withdrewamount = base.Withdraw(amount);
            if (!withdrewamount)
            {
                Balance -= _overdraftFee;
            }
            return withdrewamount;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }//class
}//namespace
