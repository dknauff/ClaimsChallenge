using System;
using System.Collections.Generic;
using System.Security.Claims;
using Claims_Challenge_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Claims_Project_Tests
{
    [TestClass]
    public class ClaimTests
    {
        [TestMethod]
        public void AddClaimToDirectory_ShouldGetCorrectBoolean()
        {
            ClaimClass testClaim = new ClaimClass();
            ClaimRepository repository = new ClaimRepository();

            bool addClaim = repository.AddClaimToDirectory(testClaim);

            Assert.IsTrue(addClaim);
        }

        [TestMethod]
        public void GetAllClaims_ShouldReturnCorrectCollection()
        {
            ClaimClass testClaim = new ClaimClass();
            ClaimRepository repository = new ClaimRepository();
            repository.AddClaimToDirectory(testClaim);

            List<ClaimClass> listOfClaims = repository.GetAllClaims();

            bool directoryHasClaims = listOfClaims.Contains(testClaim);
            Assert.IsTrue(directoryHasClaims);
        }

        [TestMethod]
        public void AddClaimToQueue_ShouldReturnCorrectCollection()
        {
            ClaimClass testclaim = new ClaimClass();
            ClaimRepository repository = new ClaimRepository();
            repository.AddClaimToQueue(testclaim);

            Queue<ClaimClass> queueOfClaims = repository.GetClaimQueue();

            bool queueHasClaims = queueOfClaims.Contains(testclaim);
            Assert.IsTrue(queueHasClaims);
        }
    }
}
