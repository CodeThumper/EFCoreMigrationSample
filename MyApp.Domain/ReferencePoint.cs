using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Domain
{
    public class ReferencePoint
    {
        public Guid? SessionId { get; set; }
        public DateTimeOffset? At { get; set; }
        public string Reason { get; set; }
    }
}
