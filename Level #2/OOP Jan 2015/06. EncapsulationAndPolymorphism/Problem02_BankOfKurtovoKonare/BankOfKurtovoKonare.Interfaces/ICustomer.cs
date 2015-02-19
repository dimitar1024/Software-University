using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Interfaces
{
    interface ICustomer
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string Address { get; set; }

        string Phone { get; set; }

        string HomePhone { get; set; }

        string Email { get; set; }

        string OfficeAddress { get; set; }
    }
}
