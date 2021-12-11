using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.Account
{
    public class MenuListDto
    {
        public long FormID { get; set; }
        public string FormName { get; set; }
        public long CatFormID { get; set; }
        public string CatName { get; set; }
        public string IconUrl { get; set; }
        public string Url { get; set; }
        public string TagClass { get; set; }
    }
}
