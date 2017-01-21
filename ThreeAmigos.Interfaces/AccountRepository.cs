using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeAmigos.Data.Models.Account;

namespace ThreeAmigos.Interfaces
{
    public interface AccountRepository
    {
        void CreateNewUser(User user);

        User RetrieveUser(int id);

        User RetrieveUserByUsername(string username);

        User RetrieveUserByEmailAddress(string emailAddress);

        void UpdateUser(User user);

        void DeleteUser(User user);


        void CreateAddress(Address address);

        Address RetrieveAddress(int id);

        ICollection<Address> RetrieveAddressesForUser(int id);

        void UpdateAddress(Address address);

        void DeleteAddress(Address address);


        void CreateAuthToken(AuthToken at);

        AuthToken RetrieveAuthToken(string token);

        void UpdateAuthToken(AuthToken at);

        void DeleteAuthToken(AuthToken at);


        void CreateBrowsingHistoryEntry(BrowsingHistoryEntry bhe);

        BrowsingHistoryEntry RetrieveBrowsingHistoryEntry(int id);

        void UpdateBrowsingHistoryEntry(BrowsingHistoryEntry bhe);

        void DeleteBrowsingHistoryEntry(BrowsingHistoryEntry bhe);


        void CreateDevice(Device device);

        Device RetrieveDevice(int id);

        ICollection<Device> RetrieveDevicesForUser(int id);

        void UpdateDevice(Device device);

        void DeleteDevice(Device device);


        void CreateRole(Role role);

        Role RetrieveRole(int id);

        void UpdateRole(Role role);

        void DeleteRole(Role role);
    }
}
