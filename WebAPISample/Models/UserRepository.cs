using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPISample.Models
{
    public class UserRepository : IDisposable
    {
        SampleEntities1 context = new SampleEntities1();
        public EmployeeDetail ValidateUser(string username, string password)
        {
            return context.EmployeeDetails.FirstOrDefault(user =>
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.UserPassword == password);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }

}