using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Companies.Attributes;

namespace Companies.Domains
{
    public abstract class BaseEntity 
    {
        public abstract int Id { get; set; }
    }
}
