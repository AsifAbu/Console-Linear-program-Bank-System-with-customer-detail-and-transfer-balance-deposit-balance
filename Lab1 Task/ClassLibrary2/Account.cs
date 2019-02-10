using System;

namespace ClassLibrary2
{
    public class Account
    {
        String accountName, accountId;
        double balance;
        public Account()
        {
        }
        public void SetAccountName(String accname)
        {
            this.accountName=accname;
        }
        public void SetAccountId(String id)
        {
            this.accountId = id;
        }
        public void SetBalnce(double balance)
        {
            this.balance = balance;
        }
        public String GetAccountNamae()
        {
            return accountName;
        }
        public String GetAccountId()
        {
            return accountId;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Deposit(double b)
        {
            this.balance=this.balance+b;
            System.Console.WriteLine("Balance Is Updated. New Balance Is : " +balance);
        }
        public void Withdraw(int a)
        {
            int w;
            if (balance >= a)
            {
                this.balance = this.balance - a;
                System.Console.WriteLine("Balance Is Updated. New Balance Is : " + balance);
            }
            else
            {
                System.Console.WriteLine("Your Current Balance Is '" + balance + "'. So You Can Not Withdraw This Amount Of Money.I Wish You Can Try Again For lower Amount.");
                System.Console.Write("Type Here Your Ammount OR If You Don't Want To Withdraw Press '1': ");
                w = (int.Parse(Console.ReadLine()));
                if (w == 1)
                {
                }
                else
                    Withdraw(w);
            }
        }
            
         public void withdrw(int a)
         {

        }
        public void ShowAll()
        {
            System.Console.WriteLine("Account Id= " + accountId);
            System.Console.WriteLine("Account Name= " + accountName);
            System.Console.WriteLine("Account Balance= " + balance);
        }
    }
}
