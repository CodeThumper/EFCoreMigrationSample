using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Domain
{
    public class Customer : ProviderTenantEntity
    {
        public string DisplayName { get; set; }
    }
}
