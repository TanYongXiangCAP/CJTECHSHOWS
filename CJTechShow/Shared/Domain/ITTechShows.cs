using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJTechShow.Shared.Domain
{
    public class ITTechShows : BaseDomainModel

    public class Main : BaseDomainModel
    {
        public int EventID { get; set; }
        public string? EventName { get; set; }
        public string? EventDuration { get; set; }
        public string? EventLocation { get; set; }
        public string? EventDescription { get; set; }
        public string? EventTicketPrice { get; set; }
        public string? EventContactInformation { get; set; }
        public string? EventRegistration { get; set; }
# public virtual Organizers? OrganizerID { get; set; }
# public virtual SponsorPage? SponsorID { get; set; }
       # public virtual VendorPage? VendorID { get; set; }


    }
}
