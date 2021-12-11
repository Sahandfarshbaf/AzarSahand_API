using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Province
    {
        public Province()
        {
            Cities = new HashSet<City>();
            UserAccessLocations = new HashSet<UserAccessLocation>();
            Users = new HashSet<User>();
        }

        public long Id { get; set; }
        public string? Title { get; set; }
        public string? CodeMapper { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<UserAccessLocation> UserAccessLocations { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
