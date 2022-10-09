using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace Example.Entities.Configurations
{
    public class OrderConfiguration:EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(100);
            HasMany(x => x.Products).WithMany(x => x.Orders);
        }
    }
}
