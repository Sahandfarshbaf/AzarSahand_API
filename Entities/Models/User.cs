using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class User
    {
        public User()
        {
            UserAccessLocations = new HashSet<UserAccessLocation>();
            UserActivations = new HashSet<UserActivation>();
            UserRoles = new HashSet<UserRole>();
        }

        public long Id { get; set; }
        public string? UserName { get; set; }
        public string? Hpassword { get; set; }
        public string? Name { get; set; }
        public string? Family { get; set; }
        public string? NationalCode { get; set; }
        public long? Bdate { get; set; }
        public long? ProvinceId { get; set; }
        public long? CityId { get; set; }
        public long? CuserId { get; set; }
        public long? Cdate { get; set; }
        public long? DuserId { get; set; }
        public long? Ddate { get; set; }
        public long? MuserId { get; set; }
        public long? Mdate { get; set; }
        public long? DaUserId { get; set; }
        public long? DaDate { get; set; }

        public virtual City? City { get; set; }
        public virtual Province? Province { get; set; }
        public virtual ICollection<UserAccessLocation> UserAccessLocations { get; set; }
        public virtual ICollection<UserActivation> UserActivations { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
