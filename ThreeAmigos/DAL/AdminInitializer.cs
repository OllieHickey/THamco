using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ThreeAmigos.Models;


namespace ThreeAmigos.DAL
{
    public class AdminInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AdminContext>
    {

        protected override void Seed(AdminContext context)
        {
            var admin = new List<Admin>
            {
            new Admin{StaffID=1,FirstName="Carson",LastName="Alexander",StaffTasks="StockUpdater",EmailAddress="carson24@hotmail.com",Password="x9412dp"},
            new Admin{StaffID=2,FirstName="Meredith",LastName="Alonso",StaffTasks="DatabaseUpdater",EmailAddress="AlonsoMerd@gmail.com",Password="wehjuw213"},
            new Admin{StaffID=3,FirstName="Arturo",LastName="Anand",StaffTasks="UserUpdater",EmailAddress="Arturo@yahoo.co.uk",Password="kkjrww567"},
            new Admin{StaffID=4,FirstName="Gytis",LastName="Barzdukas",StaffTasks="StockUpdater",EmailAddress="GytisBarzdukas@hotmail.co.uk",Password="fdghjw58"},
            new Admin{StaffID=5,FirstName="Yan",LastName="Li",StaffTasks="UserUpdater",EmailAddress="YanLi@gmail.co.uk",Password="ghjfsdui2137"},
            new Admin{StaffID=6,FirstName="Peggy",LastName="Justice",StaffTasks="DatabaseUpdater",EmailAddress="PeggyJustice@gmail.co.uk",Password="rreuretu454"},
            new Admin{StaffID=7,FirstName="Laura",LastName="Norman",StaffTasks="RepositryUpdater",EmailAddress="Laura94@hotmail.com",Password="jsdfao4u310"},
            new Admin{StaffID=8,FirstName="Nino",LastName="Olivetto",StaffTasks="StockUpdater",EmailAddress="elNino@gmail.co.uk",Password="hyjntsd54667"}
            };

            admin.ForEach(s => context.AdminDetails.Add(s));
            context.SaveChanges();

            var user = new List<Users>
            {
            new Users{UserID=1,FirstName="Jack",LastName="Anderson",EmailAddress="JackAnderson@hotmail.com",Password="m345we",CardType="Visa Debit",DebitCreditCardNumber=23412345,ExpiryDate=DateTime.Parse("2018-09-01")},
            new Users{UserID=2,FirstName="John",LastName="Redford",EmailAddress="Reford@gmail.com",Password="ghj5464123",CardType="Mastercard",DebitCreditCardNumber=453539234,ExpiryDate=DateTime.Parse("2019-12-29")},
            new Users{UserID=3,FirstName="Matt",LastName="Simons",EmailAddress="SimonsM@yahoo.co.uk",Password="54fefefe5",CardType="Maestro",DebitCreditCardNumber=56756223,ExpiryDate=DateTime.Parse("2020-06-12")},
            new Users{UserID=4,FirstName="Louise",LastName="Lee",EmailAddress="Louise88@hotmail.co.uk",Password="thyt44786",CardType="Visa Electron",DebitCreditCardNumber=65789773,ExpiryDate=DateTime.Parse("2018-11-23")},
            new Users{UserID=5,FirstName="Mary",LastName="Jones",EmailAddress="MaryisAmazing@gmail.co.uk",Password="sdfhjk234",CardType="American Express",DebitCreditCardNumber=2344676,ExpiryDate=DateTime.Parse("2018-09-11")},
            new Users{UserID=6,FirstName="Niamh",LastName="Harrington",EmailAddress="princess1994@gmail.co.uk",Password="12yuasdx3",CardType="Visa Debit",DebitCreditCardNumber=9734577,ExpiryDate=DateTime.Parse("2018-10-22")},
            new Users{UserID=7,FirstName="Anton",LastName="Dalton",EmailAddress="DaltonAnton@hotmail.com",Password="56jgh345",CardType="Visa Debit",DebitCreditCardNumber=78956732,ExpiryDate=DateTime.Parse("2020-02-24")},
            new Users{UserID=8,FirstName="Jason",LastName="Broadman",EmailAddress="Broadman@gmail.co.uk",Password="hgfdgfh767",CardType="Visa Debit",DebitCreditCardNumber=67891233,ExpiryDate=DateTime.Parse("2018-12-27")}
            };
            user.ForEach(s => context.UserDetails.Add(s));
            context.SaveChanges();
            
        }
    }
}