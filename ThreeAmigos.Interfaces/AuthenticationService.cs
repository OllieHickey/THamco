using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeAmigos.Data.Models.Account;

namespace ThreeAmigos.Interfaces
{
    public interface AuthenticationService
    {

        AuthToken AuthenticateUserById(int id, string password);

        AuthToken AuthenticateUserByUsername(string username, string password);

        AuthToken AuthenticateUserByEmailAddress(string emailAddress, string password);

        AuthToken AuthenticateUserByUsernameOrEmailAddress(string usernameOrEmailAddress, string password);

        User GetUserByAuthToken(AuthToken token);

        User GetUserByAuthToken(string token);
    }
}
