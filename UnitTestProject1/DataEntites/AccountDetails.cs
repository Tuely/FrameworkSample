using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.DataEntites
{
   public  class AccountDetails
    {
        public AccountDetails()
        {
            Title = "Mr";
            FirstName = "Test";
        }
        public string Title { get; set; }
        public string FirstName { get; set; }
    }
}
