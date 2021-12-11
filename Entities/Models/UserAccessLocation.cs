using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class UserAccessLocation
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? ProvinceId { get; set; }
        public long? CityId { get; set; }

        public virtual City? City { get; set; }
        public virtual Province? Province { get; set; }
        public virtual User? User { get; set; }
    }
}
