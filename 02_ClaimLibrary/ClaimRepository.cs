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

        private Queue<Claim> _listOfClaims = new Queue<Claim>();

        //Create
        public void EnterNewClaim(Claim content)
        {
            _listOfClaims.Enqueue(content);
        }

        //Read
        public Queue<Claim> GetClaimsList()
        {
            return _listOfClaims;
        }

        public Claim ViewNextClaim()
        {
            return _listOfClaims.Peek();        
        }

        public void RemoveTopClaim()
        {
            _listOfClaims.Dequeue();
        }

    }
}
