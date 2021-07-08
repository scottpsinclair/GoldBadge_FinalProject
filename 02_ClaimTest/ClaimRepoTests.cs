using _02_ClaimLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_ClaimTest
{
    [TestClass]
    public class ClaimRepoTests
    {
        [TestMethod]
        public void EnterNewClaim_ShouldGetNotNull()
        {
            Claim content = new Claim();
            ClaimRepository repository = new ClaimRepository();

            bool addResult = repository.EnterNewClaim(content);
            

            Assert.IsTrue(addResult);
        }
    }
}
