using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool validate(Gamer gamer)
        {
            if (gamer.BirthDay==15 && gamer.LastName=="ceylan" && gamer.FirstName=="kadir" &&gamer.IdentityNumber==15615665 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
