using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJTechShow.Shared.Domain
{
    public class Vendors
    {
     
        public int VendorsID { get; set; }

        public string? VendorName { get; set; }
        public string? VendorContactDetails { get; set; }
        public int BoothNumber { get; set; }
        public string? VendorDescription { get; set; }
        public string? Products { get; set; }
        public string? SocialMedia { get; set; }

        public int SponserID { get; set; }
        public int EventID { get; set; }
        public int OrganizersID { get; set; }
        public int VisitorID { get; set; }

    }
}
