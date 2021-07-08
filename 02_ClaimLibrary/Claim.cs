using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimLibrary
{
    public enum ClaimType
    {
        Car,
        Home,
        Theft
    }

    public class Claim
    {
        
        //Properties
        public int ClaimID
        {
            get; set;
        }
        public ClaimType TypeOfClaim
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public decimal ClaimAmount
        {
            get; set;
        }
        public DateTime DateOfIncident
        {
            get; set;
        }
        public DateTime DateOfClaim

        {
            get; set;
        }
        public bool IsValid
        {
            get
            {
                if ((DateOfIncident - DateOfClaim).TotalDays <= 30)
                    return true;
                
                return false;
            }
            
        }

        
       
        //Constructor Empty
        public Claim() { }
        //Constructor Full
        public Claim(int claimId, ClaimType typeOfClaim, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimId;
            TypeOfClaim = typeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            
        }
    }
}
