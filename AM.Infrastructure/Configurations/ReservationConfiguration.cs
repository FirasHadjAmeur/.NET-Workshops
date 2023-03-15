using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(r => new { r.SeatFk, r.PassengerFk });

            builder.HasOne(p => p.Passenger)
                .WithMany(t => t.Reservations)
                .HasForeignKey(t => t.PassengerFk);

            builder.HasOne(p => p.Seat)
                .WithMany(t => t.Reservations)
                .HasForeignKey(t => t.SeatFk);
        }
    }
}
