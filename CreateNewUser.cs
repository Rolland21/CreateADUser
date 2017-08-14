using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployee
{
    public class CreateNewUser
    {
        
        public CreateNewUser(User user)
        {

        }

        public string SamAccountName(string name, string surName)
        {
            string samAccountName = name;
            for (int i = 0; i < surName.Length; i++)
            {
                samAccountName += surName[i];
                if (UserExist.ExistInAD(samAccountName)) { continue; }
                else { break; }
               
            }
            return samAccountName;
        }
    }

}
