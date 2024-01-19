using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJTechShow.Shared.Domain
{
    public class SponsorPage : BaseDomainModel
    {
        //public int SponsorID { get; set; }

        public string? SponsorName { get; set; }

        public string? SponsorContactInfo { get; set; }
        public virtual Main? EventID { get; set; }
        public virtual Organizer? OrganizerID { get; set; }

    }
}
