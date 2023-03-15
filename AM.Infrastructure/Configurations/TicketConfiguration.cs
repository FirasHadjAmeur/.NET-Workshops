using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new {t.FlightFk , t.PassengerFk});

            builder.HasOne(p => p.Passenger)
                .WithMany(t => t.Tickets)
                .HasForeignKey(t => t.PassengerFk);

            builder.HasOne(p => p.Flight)
                .WithMany(t => t.Tickets)
                .HasForeignKey(t => t.FlightFk);

        }
    }
}
