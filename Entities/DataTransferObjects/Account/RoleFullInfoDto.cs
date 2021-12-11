using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.Account
{
    public class RoleFullInfoDto
    {
        public long Id { get; set; }
        public long? Pid { get; set; }
        public string Name { get; set; }
        public int? Rkey { get; set; }
        public int? MaxUser { get; set; }
        public long? StartDate { get; set; }
        public long? EndDate { get; set; }
        public long? FinalStatusId { get; set; }
        public List<RoleFormDto> RoleFormList { get; set; }
    }
}
