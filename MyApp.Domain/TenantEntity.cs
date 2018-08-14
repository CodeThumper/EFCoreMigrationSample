using System;

namespace MyApp.Domain
{
    public abstract class TenantEntity
    {
        public Guid TenantId { get; set; }
        public byte[] RowVersion { get; set; }
        public ReferencePoint Created { get; set; } = new ReferencePoint();
    }
}
