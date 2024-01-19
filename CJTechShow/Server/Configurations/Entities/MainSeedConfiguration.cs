using CJTechShow.Shared.Domain;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;


namespace CJTechShow.Server.Configurations.Entities
{
    public class MainSeedConfiguration : IEntityTypeConfiguration<Main>
    {

        public void Configure(EntityTypeBuilder<Main> builder)
        {
            builder.HasData(

new Main
{
    EventID = 1,
    EventName = "IT Tech Show Suntec City",
    EventDuration = "96961234",
    EventLocation = "Suntec City, Postal code:039053",
    EventDescription = "IT Tech Show",
    EventTicketPrice = "Visitor:$100 ,Vendor:$80",
    EventContactInformation = "69691234",
    OrganizerID = 1,
    VendorID = 1
},
new Main
{
    EventID = 2,
    EventName = "IT Tech Show Expo",
    EventDuration = "10am-8pm",
    EventLocation = "Expo, Postal code:392012",
    EventDescription = "IT Tech Show",
    EventTicketPrice = "Visitor:$100 ,Vendor:$80",
    EventContactInformation = "69691234",
    OrganizerID = 2,
    VendorID = 2
}
    );
    }
    }
}