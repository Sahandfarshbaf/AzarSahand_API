using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.Account
{
    public class FormDto
    {
        public long Id { get; set; }
        public long? CatFormId { get; set; }
        public string CatFormName { get; set; }
        public string Name { get; set; }
        public int? Rkey { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
        public string TagClass { get; set; }
    }
}
