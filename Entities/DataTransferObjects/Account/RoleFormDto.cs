using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.Account
{
 public  class RoleFormDto
    {
        public long RoleFormId { get; set; }
        public long? FormId { get; set; }
        public string FormName { get; set; }
    }
}
