using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployee
{
    public static class UserExist
    {
        public static bool ExistInAD(string samAccountName)
        {
            PrincipalContext firstPrincipal = new PrincipalContext(ContextType.Domain, "mymiratech", "DC=mymiratech,DC=com");
            UserPrincipal firstDomain = UserPrincipal.FindByIdentity(firstPrincipal, samAccountName);
            
            if (firstDomain != null)  return true;
            else return false;           
        }
    }
}
