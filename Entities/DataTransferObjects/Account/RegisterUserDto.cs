using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.Account
{
    public class RegisterUserDto
    {
        public string NationalCode { get; set; }
        public string CeoNationalCode { get; set; }
        public long MobileNo { get; set; }
        public bool HasAutoExpoLicense { get; set; }
        public long WorkPlacePostalCode { get; set; }
        public long WorkPlacePhone { get; set; }
        public long WorkPlaceMobile { get; set; }
        public string WorkPlaceTitle { get; set; }
    }
}
