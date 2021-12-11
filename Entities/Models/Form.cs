using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Form
    {
        public Form()
        {
            RoleForms = new HashSet<RoleForm>();
        }

        public long Id { get; set; }
        public long? CatForm { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Icone { get; set; }
        public string? Class { get; set; }

        public virtual CatForm? CatFormNavigation { get; set; }
        public virtual ICollection<RoleForm> RoleForms { get; set; }
    }
}
