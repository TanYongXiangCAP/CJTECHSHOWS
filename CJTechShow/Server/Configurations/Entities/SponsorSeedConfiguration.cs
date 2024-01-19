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
    public class SponsorPageSeedConfiguration : IEntityTypeConfiguration<SponsorPage>
    {

        public void Configure(EntityTypeBuilder<SponsorPage> builder)
        {
            builder.HasData(

new SponsorPage
{
    SponsorName = "Sukh Ma",
    SponsorContactInfo = "93939231",
    EventID = 1,
    OrganizerID = 1
},
new SponsorPage
{
    SponsorName = "Bendover",
    SponsorContactInfo = "94942314",
    EventID = 2,
    OrganizerID = 2
}
);
        }
    }
}
