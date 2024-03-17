using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

public class IndividualCustomer : BaseCustomer
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string NationalIdentity { get; set; }
}
