using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderAndCargoManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAndCargoManagement.DataAccess.Concrete.Mappings
{
    public class ArasCargoMap : IEntityTypeConfiguration<ArasCargo>
    {
        public void Configure(EntityTypeBuilder<ArasCargo> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).HasMaxLength(70);
            builder.Property(a=>a.Name).IsRequired(true);
            builder.Property(a => a.OrderCreatedDate).IsRequired(false);
            builder.Property(a => a.OrderCanceledDate).IsRequired(false);

        }
    }
}
