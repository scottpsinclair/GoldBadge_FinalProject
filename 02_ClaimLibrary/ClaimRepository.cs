using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimLibrary
{
    public class ClaimRepository
    {
        //1. See all claims
        //2. Take care of next claim
        //3. Enter a new claim

        private List<Claim> _listOfClaims = new List<Claim>();

        //Create
        public void EnterNewClaim(Claim content)
        {
            _listOfClaims.Add(content);
        }

        //Read
        public List<Claim> GetClaimsList()
        {
            return _listOfClaims;
        }
    }
}
