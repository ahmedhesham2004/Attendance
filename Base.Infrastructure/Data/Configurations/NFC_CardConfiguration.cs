using Base.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Infrastructure.Data.Configurations;
public class NFC_CardConfiguration : IEntityTypeConfiguration<NFC_Card>
{
    public void Configure(EntityTypeBuilder<NFC_Card> builder)
    {
        var nFC_Cards = new List<NFC_Card>
        {
            new NFC_Card
            {
                Id = 1,
                Code = "12345",
                ImageUrl = "CardImages/Default-Image.jpg",
                StudentId = 1
            }
        };

        //builder.HasData(nFC_Cards);
    }
}
