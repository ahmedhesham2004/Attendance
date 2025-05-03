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
            //1 : 35
            new NFC_Card
            {
                Id = 1,
                Code = "1",
                ImageUrl = "CardImages/1.jpg",
                StudentId = 1
            },
            new NFC_Card
            {
                Id = 2,
                Code = "2",
                ImageUrl = "CardImages/2.jpg",
                StudentId = 2
            },
            new NFC_Card
            {
                Id = 3,
                Code = "3",
                ImageUrl = "CardImages/3.jpg",
                StudentId = 3
            },
            new NFC_Card
            {
                Id = 4,
                Code = "4",
                ImageUrl = "CardImages/4.jpg",
                StudentId = 4
            },
            new NFC_Card
            {
                Id = 5,
                Code = "5",
                ImageUrl = "CardImages/5.jpg",
                StudentId = 5
            },
            new NFC_Card
            {
                Id = 6,
                Code = "6",
                ImageUrl = "CardImages/6.jpg",
                StudentId = 6
            },
            new NFC_Card
            {
                Id = 7,
                Code = "C3345325",
                ImageUrl = "CardImages/7.jpg",
                StudentId = 7
            },
            new NFC_Card
            {
                Id = 8,
                Code = "8",
                ImageUrl = "CardImages/8.jpg",
                StudentId = 8
            },
            new NFC_Card
            {
                Id = 9,
                Code = "9",
                ImageUrl = "CardImages/9.jpg",
                StudentId = 9
            },
            new NFC_Card
            {
                Id = 10,
                Code = "10",
                ImageUrl = "CardImages/10.jpg",
                StudentId = 10
            },
            new NFC_Card
            {
                Id = 11,
                Code = "11",
                ImageUrl = "CardImages/11.jpg",
                StudentId = 11
            },
            new NFC_Card
            {
                Id = 12,
                Code = "12",
                ImageUrl = "CardImages/12.jpg",
                StudentId = 12
            },
            new NFC_Card
            {
                Id = 13,
                Code = "13",
                ImageUrl = "CardImages/13.jpg",
                StudentId = 13
            },
            new NFC_Card
            {
                Id = 14,
                Code = "14",
                ImageUrl = "CardImages/14.jpg",
                StudentId = 14
            },
            new NFC_Card
            {
                Id = 15,
                Code = "15",
                ImageUrl = "CardImages/15.jpg",
                StudentId = 15
            },
            new NFC_Card
            {
                Id = 16,
                Code = "16",
                ImageUrl = "CardImages/16.jpg",
                StudentId = 16
            },
            new NFC_Card
            {
                Id = 17,
                Code = "17",
                ImageUrl = "CardImages/17.jpg",
                StudentId = 17
            },
            new NFC_Card
            {
                Id = 18,
                Code = "18",
                ImageUrl = "CardImages/18.jpg",
                StudentId = 18
            },
            new NFC_Card
            {
                Id = 19,
                Code = "19",
                ImageUrl = "CardImages/19.jpg",
                StudentId = 19
            },
            new NFC_Card
            {
                Id = 20,
                Code = "20",
                ImageUrl = "CardImages/20.jpg",
                StudentId = 20
            },
            new NFC_Card
            {
                Id = 21,
                Code = "21",
                ImageUrl = "CardImages/21.jpg",
                StudentId = 21
            },
            new NFC_Card
            {
                Id = 22,
                Code = "22",
                ImageUrl = "CardImages/22.jpg",
                StudentId = 22
            },
            new NFC_Card
            {
                Id = 23,
                Code = "23",
                ImageUrl = "CardImages/23.jpg",
                StudentId = 23
            },
            new NFC_Card
            {
                Id = 24,
                Code = "24",
                ImageUrl = "CardImages/24.jpg",
                StudentId = 24
            },
            new NFC_Card
            {
                Id = 25,
                Code = "25",
                ImageUrl = "CardImages/25.jpg",
                StudentId = 25
            },
            new NFC_Card
            {
                Id = 26,
                Code = "26",
                ImageUrl = "CardImages/26.jpg",
                StudentId = 26
            },
            new NFC_Card
            {
                Id = 27,
                Code = "27",
                ImageUrl = "CardImages/27.jpg",
                StudentId = 27
            },
            new NFC_Card
            {
                Id = 28,
                Code = "28",
                ImageUrl = "CardImages/28.jpg",
                StudentId = 28
            },
            new NFC_Card
            {
                Id = 29,
                Code = "29",
                ImageUrl = "CardImages/29.jpg",
                StudentId = 29
            },
            new NFC_Card
            {
                Id = 30,
                Code = "30",
                ImageUrl = "CardImages/30.jpg",
                StudentId = 30
            },
            new NFC_Card
            {
                Id = 31,
                Code = "31",
                ImageUrl = "CardImages/31.jpg",
                StudentId = 31
            },
            new NFC_Card
            {
                Id = 32,
                Code = "32",
                ImageUrl = "CardImages/32.jpg",
                StudentId = 32
            },
            new NFC_Card
            {
                Id = 33,
                Code = "33",
                ImageUrl = "CardImages/33.jpg",
                StudentId = 33
            },
            new NFC_Card
            {
                Id = 34,
                Code = "34",
                ImageUrl = "CardImages/34.jpg",
                StudentId = 34
            },
            new NFC_Card
            {
                Id = 35,
                Code = "35",
                ImageUrl = "CardImages/35.jpg",
                StudentId = 35
            }

        };

        builder.HasData(nFC_Cards);
    }
}
