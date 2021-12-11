using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CatRole
    {
        public CatRole()
        {
            Roles = new HashSet<Role>();
        }

        public long Id { get; set; }
        public string? Title { get; set; }
        public long? Rkey { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
