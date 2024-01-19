using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CJTechShow.Shared.Domain
{
    public class Visitor
    { 
        public int VisitorID { get; set; }
        public string? VisitorName { get; set; }
        public string? VisitorContactNumber { get; set; }
        public string? VisitorEmail { get; set; }
        public string? VisitorCompany { get; set; }
    }

}
