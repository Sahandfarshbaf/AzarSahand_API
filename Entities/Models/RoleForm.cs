using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class RoleForm
    {
        public long Id { get; set; }
        public long? RoleId { get; set; }
        public long? FormId { get; set; }

        public virtual Form? Form { get; set; }
        public virtual Role? Role { get; set; }
    }
}
