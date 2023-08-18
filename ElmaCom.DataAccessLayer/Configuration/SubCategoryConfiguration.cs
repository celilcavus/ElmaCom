using ElmaCom.Entity.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElmaCom.DataAccessLayer.Configuration
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            //== Sub Cat. Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();


            //== Sub Cat. Name
            builder.Property(x => x.SubCategoryName)
               .HasMaxLength(100)
               .IsRequired();

            //== Sub Cat. Description
            builder.Property(x => x.Description)
               .HasMaxLength(100)
               .IsRequired();
        }
    }
}
