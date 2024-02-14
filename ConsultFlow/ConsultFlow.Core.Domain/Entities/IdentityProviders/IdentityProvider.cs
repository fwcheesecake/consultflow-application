using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultFlow.Core.Domain.Entities.IdentityProviders
{
    public class IdentityProvider
    {
        public string ProviderId { get; private set; }
        public string Provider {  get; private set; }
        public string ProviderName { get; private set; }
    }
}
