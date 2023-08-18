using ElmaCom.Entity.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElmaCom.DataAccessLayer.Configuration
{
    public class BaseCategoryConfiguration : IEntityTypeConfiguration<BaseCategory>
    {
        public void Configure(EntityTypeBuilder<BaseCategory> builder)
        {  
            //== Category Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            //== Category Name
            builder.Property(x => x.CategoryName)
                .HasMaxLength(100)
                .IsRequired();

            //== Category Description
            builder.Property(x => x.Description)
               .HasMaxLength(100)
               .IsRequired();
        }
    }
}
