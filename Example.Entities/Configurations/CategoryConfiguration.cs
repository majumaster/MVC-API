using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities.Models;
using System.Data.Entity.ModelConfiguration;


namespace Example.Entities.Configurations
{
    public class CategoryConfiguration:EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasMaxLength(50);
            HasMany(x => x.Products).WithRequired(x => x.Category).HasForeignKey(x => x.CategoryId);
        }
    }
}
