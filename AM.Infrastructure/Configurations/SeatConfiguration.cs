using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Seat> builder)
        {
            builder.HasOne(p => p.Seat)
                 .WithMany(t => t.Seaction)
                 .HasForeignKey(t => t.SectionFk);
        }
    }
}
