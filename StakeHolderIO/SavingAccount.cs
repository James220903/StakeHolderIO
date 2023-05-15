namespace StakeHolderIO
{
    public class SavingAccount
    {
        private static int CashMoney = 0;

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
            choice = Convert.ToInt32(Console.ReadLine());

            int amount;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the amount to deposit: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    Deposit(amount);
                    MainMenu.ShowMenu();
                    break;

                case 2:
                    Console.WriteLine("Enter the amount to withdraw: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    RemoveCashMoney(amount);
                    MainMenu.ShowMenu();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
                    
            }
        }
    }
}


