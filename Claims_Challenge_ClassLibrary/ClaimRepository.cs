using System;
using System.Collections.Generic;
using System.Linq;
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

        //Claim Queue of some sort + method
        
    }
}
