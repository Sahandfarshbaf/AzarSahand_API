using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleForms = new HashSet<RoleForm>();
            UserRoles = new HashSet<UserRole>();
        }

        public long Id { get; set; }
        public long? CatRoleId { get; set; }
        public string? Title { get; set; }
        public long? Rkey { get; set; }

        public virtual CatRole? CatRole { get; set; }
        public virtual ICollection<RoleForm> RoleForms { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
