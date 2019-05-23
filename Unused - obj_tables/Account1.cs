using System;

namespace ecommerce
{
    class Account1
    {
        int accountID;
        String username;
        decimal balance;

        public int AccountID
        {
            get { return this.accountID; }
            set { this.accountID = value; }
        }

        public String Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Account1() : base()
        {
        }
    }
}
