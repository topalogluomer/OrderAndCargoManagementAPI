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
    public class YurticiCargoMap : IEntityTypeConfiguration<YurticiCargo>
    {
        public void Configure(EntityTypeBuilder<YurticiCargo> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).HasMaxLength(70);
            
        }
    }
}
