using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class City
    {
        public City()
        {
            UserAccessLocations = new HashSet<UserAccessLocation>();
            Users = new HashSet<User>();
        }

        public long Id { get; set; }
        public long? ProvinceId { get; set; }
        public string? Title { get; set; }
        public string? CodeMapper { get; set; }
        public bool? IsActive { get; set; }

        public virtual Province? Province { get; set; }
        public virtual ICollection<UserAccessLocation> UserAccessLocations { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
