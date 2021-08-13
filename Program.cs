using System;

namespace ConsoleBankC_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = 0;
            DateTime date = new DateTime(2020, 6, 2);
            Client client = new Client("abcdef", "Jens De Nijs", date);
            BankAccount bankAccount = new BankAccount("abcdef", 2000, "Visa");
            //Console.Write(client);

            Console.WriteLine('\n' +client.getId + '\n' + client.getName + '\n' + client.GetDate);

            while (numb == 0)
            {
                Console.WriteLine("\nYour balance is: " + bankAccount.balanceAmount + ".\ndo you want to withdraw or deposit? (w/d)");
                string wOrD = Console.ReadLine();
                if (wOrD.ToLower() == "w" || wOrD.ToLower() == "withdraw")
                {
                    Console.WriteLine("What is the amount you want to withdraw?");
                    int withd = Convert.ToInt32(Console.ReadLine());
                    if (bankAccount.balanceAmount - withd >= 0)
                    {
                        bankAccount.withdrawBalance(withd);
                        
                    }else{
                        Console.WriteLine("You dont have enough Monayy");
                    }
                }
                else if (wOrD.ToLower() == "d" || wOrD.ToLower() == "deposit")
                {
                    Console.WriteLine("What is the amount you want to deposit?");
                    int depo = Convert.ToInt32(Console.ReadLine());
                    bankAccount.depositBalance(depo);
                    
                }
            }

        }
    }
    class BankAccount
    {
        private string client;
        private int balance;
        private string type;

        public BankAccount(string client, int balance, string type)
        {
            this.client = client;
            this.balance = balance;
            this.type = type;
        }

        public int balanceAmount
        {
            get { return this.balance; }
        }
        public void depositBalance(int amount)
        {
            this.balance += amount;
        }
        public void withdrawBalance(int amount)
        {
            this.balance -= amount;
        }

    }

    class Client
    {
        private string id;
        private string name;
        private DateTime dateJoined;

        public Client(string id, string name, DateTime dateJoined)
        {
            this.id = id;
            this.name = name;
            this.dateJoined = dateJoined;
        }
        public string getId
        {
            get { return this.id; }
        }
        public string getName
        {
            get { return this.name; }
        }
        public DateTime GetDate
        {
            get { return this.dateJoined; }
        }



    }
}
