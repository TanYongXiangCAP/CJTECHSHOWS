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
    public class VendorPageSeedConfiguration : IEntityTypeConfiguration<VendorPage>
    {

        public void Configure(EntityTypeBuilder<VendorPage> builder)
        {
            builder.HasData(

new VendorPage
    {
        VendorID = 1,
        VendorName = "Derrick Choo",
        VendorContactDetails = "96961234",
        BoothNumber = 1,
        VendorDescription = "BNM Technology Pte Ltd, Leading IT product sales",
        Products = "Graphics Cards, Headsets,Microphones,keyboards",
        SocialMedia ="BNM_Tech"
    },
new VendorPage
    {
        VendorID = 2,
        VendorName = "Darius Yeo",
        VendorContactDetails = "94532356",
        BoothNumber = 2,
        VendorDescription = "AIChatGPT Technology Pte Ltd, Leading CHATGPT seller",
        Products = "CHATGPT",
        SocialMedia = "CHATGPT_AIKING"
}
);
        }
    }
}
