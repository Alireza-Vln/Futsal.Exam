using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Persistanc.Teams
{
    public class TeamMap : IEntityTypeConfiguration<DbContext>
    {
        public void Configure(EntityTypeBuilder<DbContext> builder)
        {
            builder.ToTable("Teams");
            builder.Property("Id").IsRequired();
            builder.Property("TeamName").HasMaxLength(50);
            builder.Property("MainColor");
            builder.Property(" SecondaryColor");
        }
    }
}
