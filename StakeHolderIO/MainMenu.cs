namespace StakeHolderIO
{
    public class MainMenu
    {
        private void MainSelectMenu()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(Console.Title = "StakeHolderIO");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cash Money: " + MoneyCounter.CashMoney);
                    Console.ResetColor();
                    Console.WriteLine("1. Buy Business");
                    Console.WriteLine("2. Bank");
                    Console.WriteLine("3. Exit");

                    // Get user input
                    if (!int.TryParse(Console.ReadLine(), out int option)) // 
                    { // if the input is not a number, display an error message and continue to the next iteration of the loop
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    switch (option)
                    {
                        case 1:
                            BuyBusiness();
                            return; // assuming that BuyBusiness() will eventually lead back to this menu
                        case 2:
                            Bank();
                            return; // assuming that Bank() will eventually lead back to this menu
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option, please try again");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An error occurred: {e.Message}\nPlease try again.");
                }
            }
        }


        private void BuyBusiness()
        {
            Console.WriteLine("1. Burger Business");
            Console.WriteLine("2. Club Business");
            Console.WriteLine("3. Bowling Business");
            Console.WriteLine("4. Back");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    // Code to buy burger business
                    break;
                case 2:
                    // Code to buy club business
                    break;
                case 3:
                    // Code to buy bowling business
                    break;
                case 4:
                    MainSelectMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again");
                    BuyBusiness();
                    break;
            }
        }

        private void Bank()
        {
            Console.Clear();
            Console.WriteLine("1. Saving Account");
            Console.WriteLine("2. Bonds");
            Console.WriteLine("3. Back");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    SavingAccount savingAccount = new();
                    savingAccount.DisplaySavingAccountBalance(); // Call the method on the instance
                    savingAccount.SavingAccountOptions(option); // Call the method on the instance
                    break;
                case 2:
                    // Code for bonds
                    break;
                case 3:
                    MainSelectMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again");
                    Bank();
                    break;
            }
        }
        public static void ShowMenu()
        {
            MainMenu menu = new();
            menu.MainSelectMenu();
        }
    }
}

