using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultFlow.Core.Domain.Entities.LoginMethod
{
    public enum LoginType
    {
        Email = 1,
        PhoneNumber = 2,
        ExternalProvider = 3,
    }
}
