using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Challenge_ClassLibrary
{
    public class ClaimRepository
    {
        protected readonly List<ClaimClass> _claimDirectory = new List<ClaimClass>();

        public bool AddClaimToDirectory(ClaimClass claim)
        {
            int startingCount = _claimDirectory.Count;
            _claimDirectory.Add(claim);
            bool wasAdded = (_claimDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<ClaimClass> GetAllClaims()
        {
            return _claimDirectory;
        }

        protected readonly Queue<ClaimClass> _claimQueue = new Queue<ClaimClass>();

        public bool AddClaimToQueue(ClaimClass claim)
        {
            int startingCount = _claimQueue.Count;
            _claimQueue.Enqueue(claim);
            bool wasAdded = (_claimQueue.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public Queue<ClaimClass> GetClaimQueue()
        {
            return _claimQueue;
        }
    }
}
