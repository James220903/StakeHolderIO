using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StakeHolderIO
{
    public class MainMenu
    {
        private void MainSelectMenu()
        {
            Console.WriteLine("Cash Money: 0");
            Console.WriteLine("1. Buy Business");
            Console.WriteLine("2. Bank");
            Console.WriteLine("3. Exit");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    BuyBusiness();
                    break;
                case 2:
                    Bank();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again");
                    MainSelectMenu();
                    break;
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
            Console.WriteLine("1. Saving Account");
            Console.WriteLine("2. Bonds");
            Console.WriteLine("3. Back");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    // Code for saving account
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
            var menu = new MainMenu();
            menu.MainSelectMenu();
        }
    }
}

