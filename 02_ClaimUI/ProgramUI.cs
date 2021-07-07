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
                        //TakeCareOfNextClaim();
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

            List<Claim> listOfClaims = _listOfClaims.GetClaimsList();

            foreach (Claim content in listOfClaims)
            {
                Console.WriteLine($"ClaimID: {content.ClaimID}", $"Type: {content.TypeOfClaim}", $"Description: {content.Description}", $"Amount: {content.ClaimAmount}", $"Date Of Incident: {content.DateOfIncident}",
                    $"Date of Claim: {content.DateOfClaim}", $"IsValid: {content.IsValid}");
            }
        }

        //TakeCareOfNextClaim

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

            ClaimType claimType;

            switch (stringClaimType)
            {
                case "1":
                    claimType = ClaimType.Car;
                    break;
                case "2":
                    claimType = ClaimType.Home;
                    break;
                case "3":
                    claimType = ClaimType.Theft;
                    break;
                default:
                    claimType = ClaimType.Car;
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
            newContent.IsValid = Console.();

            _listOfClaims.EnterNewClaim(newContent);
        }




        //Seed Method
        private void SeedContnetList()
        {
            Claim car = new Claim(1, ClaimType.Car, "Car accident on 465", 400.00m, (2021, 07, 01), 07 / 06 / 2021, true);

            _listOfClaims.EnterNewClaim(car);
        }
    }
}
//ClaimID
//ClaimType
//Description
//ClaimAmount
//DateOfIncident
//DateOfClaim
//IsValid