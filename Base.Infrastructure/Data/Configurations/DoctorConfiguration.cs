using Base.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Infrastructure.Data.Configurations;
public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        var doctors = new List<Doctor>
        {
            new Doctor
            {
                Id = 1,
                ApplicationUserId = "10eb7637-95f4-45d2-b200-84dbb188ec41"
            },
            new Doctor
            {
                Id = 2,
                ApplicationUserId = "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1"
            },
            new Doctor
            {
                Id = 3,
                ApplicationUserId = "a0e2f1e7-53e5-416f-b0b0-ca4668563233"
            },
            new Doctor
            {
                Id = 4,
                ApplicationUserId = "52511e3a-0690-45b0-9e52-02667a473b18"
            },
            new Doctor
            {
                Id = 5,
                ApplicationUserId = "52511e3a-0690-45b0-9e52-02667a473c23"
            },
            new Doctor
            {
                Id = 6,
                ApplicationUserId = "u12vw34x-5y6z-7a8b-9c0d-1e2f3g4h5i6j"
            },
            new Doctor
            {
                Id = 7,
                ApplicationUserId = "v23wx45y-6z7a-8b9c-0d1e-2f3g4h5i6j7k"
            },
            new Doctor
            {
                Id = 8,
                ApplicationUserId = "w34xy56z-7a8b-9c0d-1e2f-3g4h5i6j7k8l"
            },
            new Doctor
            {
                Id = 9,
                ApplicationUserId = "x45yz67a-8b9c-0d1e-2f3g-4h5i6j7k8l9m"
            },
            new Doctor
            {
                Id = 10,
                ApplicationUserId = "y56za78b-9c0d-1e2f-3g4h-5i6j7k8l9m0n"
            },
            new Doctor
            {
                Id = 11,
                ApplicationUserId = "z67ab89c-0d1e-2f3g-4h5i-6j7k8l9m0n1o"
            },
            new Doctor
            {
                Id = 12,
                ApplicationUserId = "a78bc90d-1e2f-3g4h-5i6j-7k8l9m0n1o2p"
            },
            new Doctor
            {
                Id = 13,
                ApplicationUserId = "b89cd01e-2f3g-4h5i-6j7k-8l9m0n1o2p3q"
            },
            new Doctor
            {
                Id = 14,
                ApplicationUserId = "c90de12f-3g4h-5i6j-7k8l-9m0n1o2p3q4r"
            },
            new Doctor
            {
                Id = 15,
                ApplicationUserId = "d01ef23g-4h5i-6j7k-8l9m-0n1o2p3q4r5s"
            }
        };

        builder.HasData(doctors);
    }
}
