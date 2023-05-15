namespace StakeHolderIO
{
    public class SavingAccount
    {
        public int CashMoney { get; private set; } = 0;

        public void Deposit(int amount)
        {
            CashMoney += amount;
            MoneyCounter.RemoveCashMoney(amount);
        }

        public void RemoveCashMoney(int amount)
        {
            if (amount <= CashMoney)
            {
                CashMoney -= amount;
                MoneyCounter.AddCashMoney(amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        public void DisplaySavingAccountBalance()
        {
            Console.WriteLine("Your saving account balance is: " + CashMoney);
        }
        public void SavingAccountOptions(int choice)
        {
            Console.WriteLine("1 to deposit money");
            Console.WriteLine("2 to withdraw money");

            int amount = 0;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the amount to deposit: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    Deposit(amount);
                    break;

                case 2:
                    Console.WriteLine("Enter the amount to withdraw: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    RemoveCashMoney(amount);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}


