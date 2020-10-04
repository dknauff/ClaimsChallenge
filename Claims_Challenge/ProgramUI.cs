using Claims_Challenge_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Challenge
{
    public class ProgramUI
    {
        private readonly ClaimRepository _claimRepository = new ClaimRepository();

        public void Run()
        {
            SeedClaims();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you wish to select: \n" +
                    "1) See all claims \n" +
                    "2) Take care of next claim \n" +
                    "3) Enter a new claim" +
                    "4) Exit menu");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        NextClaim();
                        break;
                    case "3":
                        EnterNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number that corresponds to a menu item!");
                }
            }
        }

        private void SeedClaims()
        {
            var claimOne = new ClaimClass(1, ClaimType.Car, "Car accident on 465", 400.00m, "4/25/18", "4/27/18", true);
            var claimTwo = new ClaimClass(2, ClaimType.Home, "House fire in kitchen", 4000.00m, "4/11/18", "4/12/18", true);
            var claimThree = new ClaimClass(3, ClaimType.Theft, "Stolen pankcakes", 4.00m, "4/27/18", "6/01/18", false);

            _claimRepository.AddClaimToDirectory(claimOne);
            _claimRepository.AddClaimToDirectory(claimTwo);
            _claimRepository.AddClaimToDirectory(claimThree);
        }
    }
}
