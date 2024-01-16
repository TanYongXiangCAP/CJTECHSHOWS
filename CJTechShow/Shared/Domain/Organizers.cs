using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CJTechShow.Shared.Domain
{
    public class Organizer
    {
        public int OrganizerID { get; set; }


        public string OrganizerName { get; set; }
        public string OrganizerContactNumber { get; set; }
        public string OrganizerPosition { get; set; }
        public string OrganizerEmail { get; set; }
        public string OrganizerPassword { get; set; }
     
        public int VendorID { get; set; }      
    }

    
}

