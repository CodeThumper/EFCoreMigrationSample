using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Domain
{
    public abstract class ProviderTenantEntity : TenantEntity
    {
        public Guid ProviderId { get; set; }
        public string ProviderKey { get; set; }
    }
}
