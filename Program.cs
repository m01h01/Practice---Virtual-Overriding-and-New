namespace Practice___Virtual__Overriding__and_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List <BankAccount> accounts = new List <BankAccount> ();

            CheckingAccount ca = new CheckingAccount("Amanda",10000);
            accounts.Add (ca);

            SavingsAccount sa = new SavingsAccount("Kristie", 20000);
            accounts.Add (sa);

            RetirementAccount ra = new RetirementAccount("Ben", 30000);
            accounts.Add (ra);

            Console.WriteLine($"Deposit $500:");
            ca.Deposit(500);
            sa.Deposit(500);
            ra.Deposit(500);

            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.WriteLine($"\nDeposit $-5000:");
            ca.Deposit(-5000);
            sa.Deposit(-5000);
            ra.Deposit(-5000);

            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.WriteLine($"\nWithdraw: $200");
            ca.Withdraw(200);
            sa.Withdraw(200);
            ra.Withdraw(200);

            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.WriteLine($"\nWithdraw: $-200000");
            ca.Withdraw(-200000);
            sa.Withdraw(-200000);
            ra.Withdraw(-200000);

            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.WriteLine($"\nOverdraw");
            ca.Withdraw(20000);
            sa.Withdraw(30000);
            ra.Withdraw(40000);

            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account);
            }


        }//main
    }//class
}//namespace