using _02_ClaimLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimUI
{
    public class ProgramUI
    {
        private ClaimRepository _listOfClaims = new ClaimRepository();

        
        //Method that runs/starts the application
        public void Run()
        {
            SeedContnetList();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                ClaimRepository claim = new ClaimRepository();
                Console.WriteLine("Select a menu option:\n" +
                    "1. See all claims \n" +
                    "2. Take care of next claim \n" +
                    "3. Enter a new claim \n" +
                    "4. Exit");

                //Get user input
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayAllClaims();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        EnterNewClaim();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //See all claims
        private void DisplayAllClaims()
        {
            Console.Clear();

            Queue<Claim> listOfClaims = _listOfClaims.GetClaimsList();

                Console.WriteLine("ClaimID | Type | Description | Amount | DateOfAccident | DateOfClaim | IsValid");

            foreach (Claim content in listOfClaims)
            {
                Console.WriteLine(content.ClaimID + "|" + content.TypeOfClaim + "|" + content.Description + "|" + content.ClaimAmount + "|" + content.DateOfIncident.ToString("d") + "|" +
                 content.DateOfClaim.ToString("d") +  "|" + content.IsValid);
            }
        }

        //TakeCareOfNextClaim

        private void TakeCareOfNextClaim()
        {
            Console.Clear();
            
            Claim listOfClaims = _listOfClaims.ViewNextClaim();
                                                     
            Console.WriteLine("Do you want to deal with this claim now(y/n)?");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
            {
                 _listOfClaims.RemoveTopClaim();
            }
            if (userInput == "n")
            {
                Menu();
            }
        }

        //EnterNewClaim
        private void EnterNewClaim()
        {
            Console.Clear();

            Claim newContent = new Claim();
            //Claim ID
            Console.WriteLine("Enter Claim ID");
            string idAsString = Console.ReadLine();
            newContent.ClaimID = int.Parse(idAsString);

            //ClaimType
            Console.WriteLine("Select Claim Type: \n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft");

            string stringClaimType = Console.ReadLine();

          
            switch (stringClaimType)
            {
                case "1":
                    newContent.TypeOfClaim = ClaimType.Car;
                    break;
                case "2":
                    newContent.TypeOfClaim = ClaimType.Home;
                    break;
                case "3":
                    newContent.TypeOfClaim = ClaimType.Theft;
                    break;
                default:
                    newContent.TypeOfClaim = ClaimType.Car;
                    break;
            }

            //Description
            Console.WriteLine("Please enter a description");
            newContent.Description = Console.ReadLine();

            //ClaimAmount
            Console.WriteLine("Please enter a claim amount");
            string amountAsString = Console.ReadLine();
            newContent.ClaimAmount = decimal.Parse(amountAsString);

            //DateOfIncident
            Console.WriteLine("Enter date of incident. 00/00/0000");
            string incidentAsString = Console.ReadLine();
            newContent.DateOfIncident = DateTime.Parse(incidentAsString);

            //DateOfClaim
            Console.WriteLine("Enter date of claim. 00/00/0000");
            string claimAsString = Console.ReadLine();
            newContent.DateOfClaim = DateTime.Parse(claimAsString);

            //IsValid
            Console.WriteLine(newContent.IsValid);


            _listOfClaims.EnterNewClaim(newContent);
        }


        //Seed Method
        private void SeedContnetList()
        {
            Claim car = new Claim(1, ClaimType.Car, "Car accident on 465", 400.00m, new DateTime(2021, 07, 01), new DateTime(2021, 07, 06));
            Claim home = new Claim(2, ClaimType.Home, "Oak tree fell on house", 2000.00m, new DateTime(2021, 05, 30), new DateTime(2021, 06, 15));
            Claim theft = new Claim(3, ClaimType.Theft, "Stolen apple pie", 10.00m, new DateTime(2021, 06, 12), new DateTime(2021, 06, 13));

            _listOfClaims.EnterNewClaim(car);
            _listOfClaims.EnterNewClaim(home);
            _listOfClaims.EnterNewClaim(theft);
        }
    }
}
